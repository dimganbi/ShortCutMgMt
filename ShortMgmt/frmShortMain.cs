using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Collections;
using IWshRuntimeLibrary;
using System.IO;

namespace ShortMgmt
{
    public partial class frmShortMain : Form
    {
        public frmShortMain()
        {
            InitializeComponent();
            dgvRegeditData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//行选择模式
            dgvRegeditData.ReadOnly = true;//只读，不可编辑
            dgvRegeditData.ColumnCount = 2;//两列数据
            dgvRegeditData.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//第二列填充数据表
            dgvRegeditData.ColumnHeadersVisible = true;//显示列标题
            dgvRegeditData.Columns[0].Name = "快捷命令";//第一列的标题
            dgvRegeditData.Columns[1].Name = "程序位置";//第二列的标题
        }

        string shortName = string.Empty;//要添加的快捷命令名称
        string shortFilePath = string.Empty;//目标文件的上层路径
        string shortFilePathWithName = string.Empty;//目标文件路径
        string selectFilePath = string.Empty;
        string selectFileName = string.Empty;//获取目标文件名称
        string shortFolderPath = string.Empty;//目标文件夹的名称
        string regeditPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths";//注册表路径
        Hashtable keyPorps = null;
        RegistryKey baseKey = null;
        RegistryKey shortKeys = null;
        bool isFileOrFolder = false;//true->文件夹，false->文件

        private void frmShortMain_Load(object sender, EventArgs e)
        {
            try
            {
                showRegeditData();//加载注册表数据
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// 加载注册表数据
        /// </summary>
        public void showRegeditData()
        {
            dgvRegeditData.Rows.Clear();
            keyPorps = new Hashtable();
            baseKey = Registry.LocalMachine;//基键
            shortKeys = baseKey.OpenSubKey(regeditPath, true);
            //List<string> keyNames = new List<string>();
            //List<string> keyPaths = new List<string>();
            try
            {
                foreach (string keyName in shortKeys.GetSubKeyNames())
                {
                    RegistryKey shortKey = shortKeys.OpenSubKey(keyName);
                    //keyPaths.Add(shortKey.GetValue("").ToString());
                    //keyNames.Add(keyName);
                    if (shortKey.GetValue("") != null)
                    {
                        keyPorps.Add(keyName.Substring(0, keyName.LastIndexOf(".")), shortKey.GetValue("").ToString());
                    }
                    else
                    {
                        keyPorps.Add(keyName.Substring(0, keyName.LastIndexOf(".")), "无效");
                    }
                    // MessageBox.Show(shortKey.GetValue("").ToString());
                }

                //遍历keyPorp来填充DataGridView中的行数据
                foreach (DictionaryEntry keyProp in keyPorps)
                {
                    string[] keys = new string[] { keyProp.Key.ToString(), keyProp.Value.ToString() };
                    dgvRegeditData.Rows.Add(keys);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 打开选择的路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linklblSelectPath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linklblSelectPath.Text);//打开该路径
        }

        /// <summary>
        /// 添加快捷命令
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddShort_Click(object sender, EventArgs e)
        {
            if (txtShortName.Text == string.Empty || txtSelectPath.Text == string.Empty)
            {
                MessageBox.Show("快捷名称或文件路径不可为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (isFileOrFolder)
                {
                    addFolderShort();
                }
                else
                {
                    addFileShort();
                }
                showRegeditData();
                txtShortName.Text = txtSelectPath.Text = string.Empty;
            }

        }

        private void btnDeleteSelect_Click(object sender, EventArgs e)
        {
            DialogResult userChoose = MessageBox.Show("该项可能涉及系统内部运行，你确定要删除吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (userChoose == DialogResult.Yes)
            {
                for (int i = 0; i < dgvRegeditData.SelectedRows.Count; i++)
                {
                    shortKeys.DeleteSubKey(dgvRegeditData.SelectedRows[i].Cells[0].Value.ToString() + ".exe", false);
                    showRegeditData();
                }
            }
            else
            {
                //Do Dothing
            }
        }

        /// <summary>
        /// 创建文件快捷方式
        /// </summary>
        /// <param name="fileName"></param>
        public void createFileShortcut(string fileName, string fileNamePath)
        {
            if (!Directory.Exists(System.IO.Directory.GetCurrentDirectory() + @"\Shortcuts"))
            {
                Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory() + @"\Shortcuts");
            }
            string shortcutPath = System.IO.Directory.GetCurrentDirectory() + @"\Shortcuts" + "\\" + fileName + ".lnk";
            try
            {
                IWshRuntimeLibrary.WshShell shell = new WshShell();
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutPath);
                shortcut.TargetPath = fileNamePath;
                shortcut.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        /// <summary>
        /// 创建文件夹快捷方式
        /// </summary>
        /// <param name="folderPath"></param>
        public void createFolderShortcut(string folderPath)
        {
            if (!Directory.Exists(System.IO.Directory.GetCurrentDirectory() + @"\Shortcuts"))
            {
                Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory() + @"\Shortcuts");
            }
            string shortcutPath = System.IO.Directory.GetCurrentDirectory() + @"\Shortcuts" + "\\" + txtShortName.Text.Trim() + ".lnk";
            try
            {
                IWshRuntimeLibrary.WshShell shell = new WshShell();
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutPath);
                shortcut.TargetPath = folderPath;
                shortcut.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelectTarget_Click(object sender, EventArgs e)
        {
            if (isFileOrFolder)
            {
                openFolderDialog();
            }
            else
            {
                openFileDialog();
            }

        }

        private void radiobtnFile_CheckedChanged(object sender, EventArgs e)
        {
            isFileOrFolder = false;
            btnSelectTarget.Text = "浏览文件";
        }

        private void radiobtnFolder_CheckedChanged(object sender, EventArgs e)
        {
            isFileOrFolder = true;
            btnSelectTarget.Text = "浏览文件夹";
        }

        public void openFileDialog()
        {
            OpenFileDialog newRunFile = new OpenFileDialog();
            newRunFile.Title = "选择要执行的文件";
            newRunFile.Filter = "可执行程序(*.exe)|*.exe";
            if (newRunFile.ShowDialog() == DialogResult.OK)
            {
                selectFileName = newRunFile.SafeFileName.Substring(0, newRunFile.SafeFileName.LastIndexOf("."));
                txtSelectPath.Text = selectFilePath = newRunFile.FileName;//获取文件路径
                linklblSelectPath.Text = newRunFile.FileName.Substring(0, newRunFile.FileName.LastIndexOf("\\"));//获取文件夹路径
            }
        }

        public void openFolderDialog()
        {
            FolderBrowserDialog newFolder = new FolderBrowserDialog();
            if (newFolder.ShowDialog() == DialogResult.OK)
            {
                txtSelectPath.Text = linklblSelectPath.Text = shortFolderPath = newFolder.SelectedPath;
            }
        }

        public void addFileShort()
        {
            try
            {
                createFileShortcut(selectFileName, selectFilePath);
                string localShortPath = System.IO.Directory.GetCurrentDirectory() + @"\Shortcuts";
                string localShortName = System.IO.Directory.GetCurrentDirectory() + @"\Shortcuts" + "\\" + selectFileName + ".lnk";
                //创建子键
                RegistryKey newShortKey = shortKeys.CreateSubKey(txtShortName.Text.Trim() + ".exe");
                //设定默认值为目标文件路径
                newShortKey.SetValue("", localShortName);
                //设定Path键/值
                newShortKey.SetValue("Path", localShortPath);
                MessageBox.Show(txtShortName.Text.Trim() + "添加成功，可在运行对话框中输入" + txtShortName.Text.Trim() + "运行程序", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void addFolderShort()
        {
            try
            {
                createFolderShortcut(shortFolderPath);
                string localShortPath = System.IO.Directory.GetCurrentDirectory() + @"\Shortcuts";
                string localShortName = System.IO.Directory.GetCurrentDirectory() + @"\Shortcuts" + "\\" + txtShortName.Text.Trim() + ".lnk";
                //创建子键
                RegistryKey newShortKey = shortKeys.CreateSubKey(txtShortName.Text.Trim() + ".exe");
                //设定默认值为目标文件路径
                newShortKey.SetValue("", localShortName);
                //设定Path键/值
                newShortKey.SetValue("Path", localShortPath);
                MessageBox.Show(txtShortName.Text.Trim() + "添加成功，可在运行对话框中输入" + txtShortName.Text.Trim() + "运行程序", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
