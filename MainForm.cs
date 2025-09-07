using System;
using System.IO;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;
using System.Windows;
using System.Windows.Input;
using Microsoft.WindowsAPICodePack;
using Microsoft.WindowsAPICodePack.Core;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Amicitia.IO;
using Pfim;
using Amicitia.IO.Binary;
using P5CutinTool;

namespace CutinTableEditor
{
    public partial class MainForm : Form
    {
        //Look at all those chickens...

        public bool darkMode = true;
        public int baseWidth;
        public int baseHeight;
        public int eyeWidth;
        public int eyeHeight;
        public bool isP5 = false;
        public bool isP54K = false;
        public bool isP5R = false;
        public bool isP5RPC = false;
        List<CutinData> cutinDataList = new List<CutinData>();
        List<string> entryNames = new List<string>();
        public int entryCount;
        public bool frameDisp = false;
        public string framePath;
        public string tablePath;
        public string orient = "000";
        public int faceCount;
        public int eyeCount;
        List<Bitmap> faceFrames = new List<Bitmap>();
        List<Bitmap> eyeFrames = new List<Bitmap>();
        public int ePosX = 0;
        public int ePosY = 0;
        public int posXCopy = 0;
        public int posYCopy = 0;

        public string fileMagic;
        public byte[] headerArray = new byte[38];

        PictureBox eyePicture = new PictureBox() { SizeMode = PictureBoxSizeMode.Normal, BackColor = Color.Transparent  };
        
        public MainForm()
        {
            InitializeComponent();
            pnl_PictureBoxContainer.Controls.Add(eyePicture);
            eyePicture.Parent = pictureBox_BaseImage;
            eyePicture.BringToFront();

            //Disable buttons and set dark mode by default
            VisualMode(darkMode);
            darkModeMenu.Enabled = false;
            OpenTable.Enabled = false;
            OpenFrames.Enabled = false;
            saveTableSM.Enabled = false;
            quickSaveTableSM.Enabled = false;
            inverseButton.Enabled = false;
            entryCombo.Enabled = false;
            numPosX.Enabled = false;
            numPosY.Enabled = false;
            nameTextBox.Enabled = false;
            copyCoordsSM.Enabled = false;
            pasteCoordsSM.Enabled = false;
            scaleMenu.SelectedIndex = 0;
#if DEBUG
            modeComboBox.SelectedIndex = 0; //P5RPC
            scaleMenu.SelectedIndex = 2;
            tablePath = @"D:\CPK\BASE.CPK_unpacked\CUTIN\TABLE\0_MAIN_0\CUTINMAIN_0_02_07.DAT";
            OpenTableDat();

            framePath = @"D:\CPK\BASE.CPK_unpacked\CUTIN\UTARC\0_MAIN_0_extracted\CUTINMAIN_0_02_07.000-0.dds";
            LoadFrames(orient);
            inverseButton.Enabled = true;
            frameDisp = true;
#endif
        }

        private Bitmap ScaleBitmap(Bitmap bmp)
        {
            int selectedScale = 100;

            if (scaleMenu.SelectedItem.ToString() != "")
                selectedScale = Convert.ToInt32(scaleMenu.SelectedItem.ToString());

            return new Bitmap(bmp, new Size((int)Math.Ceiling((double)bmp.Width * ((double)selectedScale / (double)100)), (int)Math.Ceiling(((double)bmp.Height * ((double)selectedScale / (double)100)))));
        }

        private void updateEyeFrame()
        {
            eyePicture.Location = ScalePoint(Convert.ToDouble(ePosX), Convert.ToDouble(ePosY));
        }

        private Point ScalePoint(double x, double y)
        {
            int selectedScale = 100;

            if (scaleMenu.SelectedItem.ToString() != "")
                selectedScale = Convert.ToInt32(scaleMenu.SelectedItem.ToString());

            return new Point((int)Math.Ceiling(x * ((double)selectedScale / (double)100)), (int)Math.Ceiling(y * ((double)selectedScale / (double)100)));
        }

        public class CutinData  //Entry structure for cutin data
        {
            public int type = 0;
            public string name = "RESERVE";
            public byte[] entryArray1 = new byte[36];
            public int posX = 0;
            public int posY = 0;
            public byte[] entryArray2 = new byte[20];
        }

        private void UnpackButton_Click(object sender, EventArgs e)
        {
            //Unpacc Input
            CommonOpenFileDialog InputFolder = new CommonOpenFileDialog();
            InputFolder.InitialDirectory = Directory.GetCurrentDirectory();
            InputFolder.AllowNonFileSystemItems = true;
            InputFolder.IsFolderPicker = true;
            InputFolder.EnsurePathExists = true;
            InputFolder.EnsureValidNames = true;
            InputFolder.Multiselect = false;
            InputFolder.Title = "Select Input Folder";
            if (InputFolder.ShowDialog() != CommonFileDialogResult.Ok || InputFolder.FileName.Length == 0)
                return;

            // Unpacc Output
            CommonOpenFileDialog OutputFolder = new CommonOpenFileDialog();
            OutputFolder.InitialDirectory = Directory.GetCurrentDirectory();
            OutputFolder.AllowNonFileSystemItems = true;
            OutputFolder.IsFolderPicker = true;
            OutputFolder.EnsurePathExists = true;
            OutputFolder.EnsureValidNames = true;
            OutputFolder.Multiselect = false;
            OutputFolder.Title = "Select Output Folder";
            if (OutputFolder.ShowDialog() != CommonFileDialogResult.Ok || OutputFolder.FileName.Length == 0)
                return;

            // Unpacking Cutins with Cutin Tool
            P5CutinTool.Program.Main(new string[] { "unpack", InputFolder.FileName, OutputFolder.FileName });
            MessageBox.Show("Done unpacking cutins!");
        }

        private void RepackButton_Click(object sender, EventArgs e)
        {
            //Repacc Input
            var InputFolder = new CommonOpenFileDialog();
            InputFolder.InitialDirectory = Directory.GetCurrentDirectory();
            InputFolder.AllowNonFileSystemItems = true;
            InputFolder.IsFolderPicker = true;
            InputFolder.EnsurePathExists = true;
            InputFolder.EnsureValidNames = true;
            InputFolder.Multiselect = false;
            InputFolder.Title = "Select Input Folder";
            if (InputFolder.ShowDialog() != CommonFileDialogResult.Ok || InputFolder.FileName.Length == 0)
                return;

            // Repacc Output
            var OutputFolder = new CommonOpenFileDialog();
            OutputFolder.InitialDirectory = Directory.GetCurrentDirectory();
            OutputFolder.AllowNonFileSystemItems = true;
            OutputFolder.IsFolderPicker = true;
            OutputFolder.EnsurePathExists = true;
            OutputFolder.EnsureValidNames = true;
            OutputFolder.Multiselect = false;
            OutputFolder.Title = "Select Output Folder";
            if (OutputFolder.ShowDialog() != CommonFileDialogResult.Ok || OutputFolder.FileName.Length == 0)
                return;

            // Repacking Cutins with Cutin Tool
            P5CutinTool.Program.Main(new string[] { "pack", InputFolder.FileName, OutputFolder.FileName });
            MessageBox.Show("Done repacking cutins!");
        }

        private void OpenFrames_Click(object sender, EventArgs e)
        {
            var openFrames = new OpenFileDialog();    //Open file dialogue is assigned to openFrames

            openFrames.Filter = "Images  (*.dds)|*.000-0.dds";
            openFrames.Title = "Select frame texture files";
            if (openFrames.ShowDialog() != DialogResult.OK || openFrames.FileName.Length == 0)
                return;

            framePath = openFrames.FileName; //Gets filename from the selected image

            LoadFrames(orient);

            inverseButton.Enabled = true;
            frameDisp = true;


        }

        private void LoadFrames(string ori) //Receives string to set frame orientation (000 for right, 001 for left)
        {
            var pathLength = framePath.Length;
            string orientation = ori;
            faceFrames.Clear();
            eyeFrames.Clear();

            for (int i = 0; i < faceCount; i++) //Adds DDS frames on loop (face frames)
            {
                framePath = $"{framePath.Remove(pathLength - 10, 10)}.{orientation}-{Convert.ToString(i)}.dds";
                DDS baseDDS = new DDS(framePath);
                baseDDS.setGame(isP5, isP5R, isP5RPC, isP54K);

                Bitmap frameBitmap = baseDDS.DDSReader();    //Calls reading method from the DDS class and adds the returned bitmap to the face frames list

                baseWidth = baseDDS.DDSWidth();
                baseHeight = baseDDS.DDSHeight();
                faceFrames.Add(frameBitmap);
            }

            for (int i = faceCount; i < faceCount + eyeCount; i++)  //Adds DDS frames on loop (eye frames)
            {
                framePath = $"{framePath.Remove(pathLength - 10, 10)}.{orientation}-{Convert.ToString(i)}.dds";
                DDS baseDDS = new DDS(framePath);
                baseDDS.setGame(isP5, isP5R, isP5RPC, isP54K);

                Bitmap frameBitmap = baseDDS.DDSReader();    //Calls reading method from the DDS class and adds the returned bitmap to the eye frames list

                eyeWidth = baseDDS.DDSWidth();
                eyeHeight = baseDDS.DDSHeight();
                eyeFrames.Add(frameBitmap);
            }
        }

        private void OpenTable_Click(object sender, EventArgs e)
        {
            var openTable = new OpenFileDialog();    //Open file dialogue is assigned to openFrames

            openTable.Filter = "Cutin Tables  (*.dat)|*.dat";
            openTable.Title = "Select cutin data table files";
            if (openTable.ShowDialog() != DialogResult.OK || openTable.FileName.Length == 0)
                return;

            tablePath = openTable.FileName; //Gets filename from the selected image 

            OpenTableDat();
        }

        private void OpenTableDat()
        {
            //Clear data lists and frame counts
            entryNames.Clear();
            entryListBox.Items.Clear();
            cutinDataList.Clear();
            faceCount = 0;
            eyeCount = 0;

            ReadDatTable(tablePath);

            foreach (string name in entryNames) //Adds names from data table to the entry listBox
            {
                entryListBox.Items.Add(name);
            }
            entryListBox.Enabled = true;
            entryListBox.SelectedIndex = 0;

            //Enable buttons
            OpenFrames.Enabled = true;
            quickSaveTableSM.Enabled = true;
            saveTableSM.Enabled = true;
            frameDisp = false;
        }

        private void darkModeMenu_Click(object sender, EventArgs e)     //Enable dark mode
        {
            darkMode = true;
            VisualMode(darkMode);
            darkModeMenu.Enabled = false;
            lightModeMenu.Enabled = true;
        }

        private void lightModeMenu_Click(object sender, EventArgs e)    //Enable light mode
        {
            darkMode = false;
            VisualMode(darkMode);
            darkModeMenu.Enabled = true;
            lightModeMenu.Enabled = false;
        }

        //ComboBox event for handling game modes
        private void modeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (modeComboBox.SelectedItem)  //This may or may not be redundant but I want to trust the process...
            {
                case "P5R (PC)":
                    isP5RPC = true;
                    isP5 = false;
                    isP5R = false;
                    isP54K = false;
                    break;
                case "P5R (PS4/Switch)":
                    isP5R = true;
                    isP5 = false;
                    isP5RPC = false;
                    isP54K = false;
                    break;
                case "P5 (PS3)":
                    isP5 = true;
                    isP5R = false;
                    isP5RPC = false;
                    isP54K = false;
                    break;
                case "P5 (4K)":
                    isP54K = true;
                    isP5 = false;
                    isP5R = false;
                    isP5RPC = false;
                    break;
                default:
                    break;
            }

            OpenTable.Enabled = true;

        }

        private void entryListBox_SelectedIndexChanged(object sender, EventArgs e)      //Wow
        {
            numPosX.Enabled = false;
            numPosY.Enabled = false;
            this.eyePicture.Image = null;
            eyePicture.Size = new Size(1,1);
            entryCombo.SelectedIndex = cutinDataList[entryListBox.SelectedIndex].type;
            nameTextBox.Text = cutinDataList[entryListBox.SelectedIndex].name;

            if (entryListBox.SelectedIndex != -1 && cutinDataList[entryListBox.SelectedIndex].type == 1 || cutinDataList[entryListBox.SelectedIndex].type == 2 || cutinDataList[entryListBox.SelectedIndex].type == 4)
            {
                //Only applies to data entries with index 1, 2 or 4
                copyCoordsSM.Enabled = true;
                numPosX.Value = cutinDataList[entryListBox.SelectedIndex].posX;
                numPosY.Value = cutinDataList[entryListBox.SelectedIndex].posY;

                //Look at type 1 frames... So simple... So serene...
                if (cutinDataList[entryListBox.SelectedIndex].type == 1 && frameDisp == true)
                {
                    //Replaces face frames in pictureBox when scrolling through the listBox
                    pictureBox_BaseImage.Image = ScaleBitmap(faceFrames[entryListBox.SelectedIndex]);
                }

                if (cutinDataList[entryListBox.SelectedIndex].type == 4 && frameDisp == true)
                {
                    //Enable position editing for offset entries, changes are not yet displayed on the tool
                    numPosX.Enabled = true;
                    numPosY.Enabled = true;
                }

                //.....
                if (entryListBox.SelectedIndex >= faceCount && cutinDataList[entryListBox.SelectedIndex].type == 2 && frameDisp == true)
                {
                    //Enable position editing only for eye frames
                    numPosX.Enabled = true; 
                    numPosY.Enabled = true;

                    switch (orient) //Switch case for orientation
                    {
                        case "000":
                            //Check for game mode to scale the coordinates in frame display
                            if (isP5 == true)
                            {
                                ePosX = cutinDataList[entryListBox.SelectedIndex].posX;
                                ePosY = cutinDataList[entryListBox.SelectedIndex].posY;
                                updateEyeFrame();
                                this.eyePicture.Image = ScaleBitmap(eyeFrames[entryListBox.SelectedIndex - faceCount]);
                                eyePicture.Size = eyePicture.Image.Size;
                            }
                            if (isP54K == true)
                            {
                                ePosX = cutinDataList[entryListBox.SelectedIndex].posX;
                                ePosY = cutinDataList[entryListBox.SelectedIndex].posY;
                                updateEyeFrame();
                                this.eyePicture.Image = ScaleBitmap(eyeFrames[entryListBox.SelectedIndex - faceCount]);
                                eyePicture.Size = eyePicture.Image.Size;
                            }
                            if (isP5R == true)  //For P5R PS4/Switch, coords * 0.6667
                            {
                                ePosX = Convert.ToInt32(cutinDataList[entryListBox.SelectedIndex].posX * 0.6667);
                                ePosY = Convert.ToInt32(cutinDataList[entryListBox.SelectedIndex].posY * 0.6667);
                                updateEyeFrame();
                                this.eyePicture.Image = ScaleBitmap(eyeFrames[entryListBox.SelectedIndex - faceCount]);
                                eyePicture.Size = eyePicture.Image.Size;
                            }
                            if (isP5RPC == true)    //For P5RPC, coords / 3
                            {
                                ePosX = Convert.ToInt32(cutinDataList[entryListBox.SelectedIndex].posX * 0.6667);
                                ePosY = Convert.ToInt32(cutinDataList[entryListBox.SelectedIndex].posY * 0.6667);
                                updateEyeFrame();
                                this.eyePicture.Image = ScaleBitmap(eyeFrames[entryListBox.SelectedIndex - faceCount]);
                                eyePicture.Size = eyePicture.Image.Size;
                            }
                            break;
                        case "001":
                            if (isP5 == true)   //When orientation is inversed, posX starts from the top right corner, so we run some funky math to achieve the same in the tool
                            {
                                //(Also hardcoded pictureBox size, but it's okay cause it technically already was in the designer, please I'm only human)
                                ePosX = 872 - cutinDataList[entryListBox.SelectedIndex].posX - eyeWidth;
                                ePosY = cutinDataList[entryListBox.SelectedIndex].posY;
                                updateEyeFrame();
                                this.eyePicture.Image = ScaleBitmap(eyeFrames[entryListBox.SelectedIndex - faceCount]);
                                eyePicture.Size = eyePicture.Image.Size;
                            }
                            if (isP54K == true)
                            {
                                ePosX = 872 - cutinDataList[entryListBox.SelectedIndex].posX - eyeWidth;
                                ePosY = cutinDataList[entryListBox.SelectedIndex].posY;
                                updateEyeFrame();
                                this.eyePicture.Image = ScaleBitmap(eyeFrames[entryListBox.SelectedIndex - faceCount]);
                                eyePicture.Size = eyePicture.Image.Size;
                            }
                            if (isP5R == true)
                            {
                                ePosX = 872 - Convert.ToInt32(cutinDataList[entryListBox.SelectedIndex].posX * 0.6667) - eyeWidth;
                                ePosY = Convert.ToInt32(cutinDataList[entryListBox.SelectedIndex].posY * 0.6667);
                                updateEyeFrame();
                                this.eyePicture.Image = ScaleBitmap(eyeFrames[entryListBox.SelectedIndex - faceCount]);
                                eyePicture.Size = eyePicture.Image.Size;
                            }
                            if (isP5RPC == true)
                            {
                                ePosX = 872 - Convert.ToInt32(cutinDataList[entryListBox.SelectedIndex].posX * 0.6667) - eyeWidth;
                                ePosY = Convert.ToInt32(cutinDataList[entryListBox.SelectedIndex].posY * 0.6667);
                                updateEyeFrame();
                                this.eyePicture.Image = ScaleBitmap(eyeFrames[entryListBox.SelectedIndex - faceCount]);
                                eyePicture.Size = eyePicture.Image.Size;
                            }
                            break;
                        default:
                            break;
                    }
                }


            }
            else
            {
                //If entry type isn't 1,2 or 4, just change the pos values (they remain uneditable)
                numPosX.Value = cutinDataList[entryListBox.SelectedIndex].posX;
                numPosY.Value = cutinDataList[entryListBox.SelectedIndex].posY;
            }
        }

        private void inverseButton_Click(object sender, EventArgs e)
        {
            switch (orient) //Change orientation string and reload the frame lists
            {
                case "000":
                    orient = "001";
                    LoadFrames(orient);
                    break;
                case "001":
                    orient = "000";
                    LoadFrames(orient);
                    break;
                default:
                    break;
            }
        }

        private void numPosX_ValueChanged(object sender, EventArgs e)
        {
            if (entryListBox.SelectedIndex >= faceCount && cutinDataList[entryListBox.SelectedIndex].type == 2 && frameDisp == true)
            {
                switch (orient)
                {
                    case "000":

                        if (isP5 == true)   //Check for game mode to update the frame display coords in the tool
                        {
                            ePosX = (int)numPosX.Value;
                            updateEyeFrame();
                        }
                        if (isP54K == true)
                        {
                            ePosX = (int)numPosX.Value;
                            updateEyeFrame();
                        }
                        if (isP5R == true)
                        {
                            ePosX = Convert.ToInt32((int)numPosX.Value * 0.6667);
                            updateEyeFrame();
                        }
                        if (isP5RPC == true)
                        {
                            ePosX = Convert.ToInt32((int)numPosX.Value * 0.6667);
                            updateEyeFrame();
                        }    

                        break;
                    case "001": //Funky maths again for orientation

                        if (isP5 == true)
                        {
                            ePosX = Convert.ToInt32(872 - (int)numPosX.Value - eyeWidth);
                            updateEyeFrame();
                        }
                        if (isP54K == true)
                        {
                            ePosX = Convert.ToInt32(872 - (int)numPosX.Value - eyeWidth);
                            updateEyeFrame();
                        }
                        if (isP5R == true)
                        {
                            ePosX = Convert.ToInt32(872 - Convert.ToInt32((int)numPosX.Value * 0.6667) - eyeWidth);
                            updateEyeFrame();
                        }
                        if (isP5RPC == true)
                        {
                            ePosX = Convert.ToInt32(872 - Convert.ToInt32((int)numPosX.Value * 0.6667) - eyeWidth);
                            updateEyeFrame();
                        }
                        break;
                    default:
                        break;
                }
            }
            cutinDataList[entryListBox.SelectedIndex].posX = (int)numPosX.Value;    //Update pos value from data entry with the one in the num button
        }

        private void numPosY_ValueChanged(object sender, EventArgs e)
        {
            if (entryListBox.SelectedIndex >= faceCount && cutinDataList[entryListBox.SelectedIndex].type == 2 && frameDisp == true)
            {

                //Check for game mode tu update display coords
                if (isP5 == true)
                {
                    ePosY = (int)numPosY.Value;
                    updateEyeFrame();
                }
                if (isP54K == true)
                {
                    ePosY = (int)numPosY.Value;
                    updateEyeFrame();
                }
                if (isP5R == true)
                {
                    ePosY = Convert.ToInt32((int)numPosY.Value * 0.6667);
                    updateEyeFrame();
                }
                if (isP5RPC == true)
                {
                    ePosY = Convert.ToInt32((int)numPosY.Value * 0.6667);
                    updateEyeFrame();
                }

                
            }
            cutinDataList[entryListBox.SelectedIndex].posY = (int)numPosY.Value;    //Update pos value from data entry with the one in the num button
        }

        private void copyCoordsSM_Click(object sender, EventArgs e)
        {
            //Assign current coords to variables in memory
            posXCopy = cutinDataList[entryListBox.SelectedIndex].posX;
            posYCopy = cutinDataList[entryListBox.SelectedIndex].posY;
            pasteCoordsSM.Enabled = true;
        }

        private void pasteCoordsSM_Click(object sender, EventArgs e)
        {
            //Assign copied pos values to current values in the data entries
            cutinDataList[entryListBox.SelectedIndex].posX = posXCopy;
            cutinDataList[entryListBox.SelectedIndex].posY = posYCopy;
        }

        private void saveTableSM_Click(object sender, EventArgs e)
        {
            var saveTable = new SaveFileDialog();

            saveTable.Filter = "Cutin Tables  (*.dat)|*.dat";
            saveTable.Title = "Save as cutin data table";
            saveTable.RestoreDirectory = true;
            if (saveTable.ShowDialog() != DialogResult.OK || saveTable.FileName.Length == 0)
                return;

            string savePath = saveTable.FileName; //Gets filename from saved table
            WriteDatTable(savePath);
        }

        public void ReadDatTable(string cutinDatPath) //Read binary data from the .dat tables
        {
            using (MemoryStream memStream = new MemoryStream(File.ReadAllBytes(cutinDatPath)))
            using (BinaryValueReader datFile = new BinaryValueReader(cutinDatPath, Endianness.Big, Encoding.ASCII))
            {


                fileMagic = datFile.ReadString(StringBinaryFormat.FixedLength, 8);
                entryCount = datFile.ReadInt16();

                headerArray = datFile.ReadArray<byte>(38);   //Skip unk data structure and saves it for later

                for (int i = 0; i < entryCount; i++)    //looped until it reaches the number of entries specified in file
                {

                    CutinData cutinDat = new CutinData();   //New cutin data entry object

                    cutinDat.type = datFile.ReadInt32();
                    cutinDat.name = datFile.ReadString(StringBinaryFormat.FixedLength, 28);
                    cutinDat.entryArray1 = datFile.ReadArray<byte>(36);    //Skips and saves 36 bytes
                    cutinDat.posX = (int)datFile.ReadUInt32();
                    cutinDat.posY = (int)datFile.ReadUInt32();
                    cutinDat.entryArray2 = datFile.ReadArray<byte>(20);    //Skips and saves 20 bytes

                    //End of the entry

                    if (cutinDat.type == 1) //Adds to the face frame count
                    {
                        faceCount = faceCount + 1;
                    }

                    if (cutinDat.type == 2) //Adds to the eye frame count
                    {
                        eyeCount = eyeCount + 1;
                    }

                    if (cutinDat.name != "")    //If an entry has a name string, add it to the listBox
                    {
                        entryNames.Add(cutinDat.name);
                    }
                    else
                    {
                        //Offset entries don't have a name in the file, so this check highlights them in the listBox (it doesn't affect their actual name strings)
                        if (cutinDat.type == 4)
                        {
                            entryNames.Add("Cutin Offset");
                        }
                        else    //If an entry of unknown type has an empty name string, display on listBox as "NULL"
                        {
                            entryNames.Add("NULL");
                        }
                    }

                    cutinDataList.Add(cutinDat);    //Add data entry to the cutinDataList

                }
            }

        }
        private void WriteDatTable(string cutinDatPath) //Binary writer. Uses variables from the tool to save data in the cutin table
        {
            using (BinaryObjectWriter writeTable = new BinaryObjectWriter(cutinDatPath, Endianness.Big, Encoding.ASCII))
            {
                writeTable.WriteString(StringBinaryFormat.FixedLength, fileMagic, 8);
                writeTable.WriteInt16((short)entryCount);
                writeTable.WriteBytes(headerArray);
                for (int i = 0; i < entryCount; i++)    //looped until it reaches the number of entries specified in file
                {
                    writeTable.WriteInt32(cutinDataList[i].type);
                    writeTable.WriteString(StringBinaryFormat.FixedLength, cutinDataList[i].name, 28);
                    writeTable.WriteBytes(cutinDataList[i].entryArray1);
                    writeTable.WriteUInt32((uint)cutinDataList[i].posX);
                    writeTable.WriteUInt32((uint)cutinDataList[i].posY);
                    writeTable.WriteBytes(cutinDataList[i].entryArray2);
                }
            }
        }

        private void quickSaveTableSM_Click(object sender, EventArgs e)     //Quick ctrl S save, asks for confirmation before saving to the same opened table
        {
            var quickSave = MessageBox.Show("This will overwrite the open data table. Will you continue?", "Save Table", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (quickSave == DialogResult.Yes)
            {
                WriteDatTable(tablePath);
            }
        }
    }
}
