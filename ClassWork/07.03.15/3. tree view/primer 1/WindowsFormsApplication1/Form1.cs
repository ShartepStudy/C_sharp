using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace TreeViewEarthBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            treeView1.SelectedNode = e.Node;
        }

        private void addContinentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInput form = new UserInput();
            form.Confirm += OnFormContinentAdd;
            form.ShowDialog();
        }

        private void OnFormContinentAdd(string name)
        {
            TreeNode node = treeView1.Nodes.Add(name);
            node.ContextMenuStrip = contextMenuContinent;
        }

        private void continentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInput form = new UserInput();
            form.Confirm += new UserInput.FormAction(OnFormFindContinent);
            form.ShowDialog();
        }

        private void OnFormFindContinent(string name)
        {
            foreach (TreeNode node in treeView1.Nodes)
            {
                if (node.Text == name)
                {
                    treeView1.SelectedNode = node;
                    return;
                }
            }
        }

        private void countryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInput form = new UserInput();
            form.Confirm += new UserInput.FormAction(OnFormFindCountry);
            form.ShowDialog();
        }

        private void OnFormFindCountry(string name)
        {
            treeView1.CollapseAll();
            foreach (TreeNode continent in treeView1.Nodes)
            {
                if (continent.Nodes.Count != 0)
                {
                    foreach (TreeNode country in continent.Nodes)
                    {
                        if (country.Text == name)
                        {
                            continent.Expand();
                            treeView1.SelectedNode = country;
                        }
                    }
                }
            }
        }

        private void cityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInput form = new UserInput();
            form.Confirm += new UserInput.FormAction(OnFormFindCity);
            form.ShowDialog();
        }

        private void OnFormFindCity(string name)
        {
            treeView1.CollapseAll();
            foreach (TreeNode continent in treeView1.Nodes)
            {
                if (continent.Nodes.Count != 0)
                {
                    foreach (TreeNode country in continent.Nodes)
                    {
                        if (country.Nodes.Count != 0)
                        {
                            foreach (TreeNode city in country.Nodes)
                            {
                                if (city.Text == name)
                                {
                                    continent.Expand();
                                    country.Expand();
                                    treeView1.SelectedNode = city;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInput form = new UserInput(treeView1.SelectedNode.Text);
            form.Confirm += new UserInput.FormAction(OnContinentEdit);
            form.ShowDialog();
        }

        private void OnContinentEdit(string name)
        {
            treeView1.SelectedNode.Text = name;
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }

        private void addCityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInput form = new UserInput();
            form.Confirm += new UserInput.FormAction(OnContinentAddCountry);
            form.ShowDialog();
        }

        private void OnContinentAddCountry(string name)
        {
            TreeNode node = treeView1.SelectedNode.Nodes.Add(name);
            node.ContextMenuStrip = contextMenuCountry;
        }

        private void countryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UserInput form = new UserInput();
            form.Confirm += new UserInput.FormAction(OnContinentFindCountry);
            form.ShowDialog();
        }
        private void OnContinentFindCountry(string name)
        {
            TreeNode continent = treeView1.SelectedNode;
            continent.Collapse();
            foreach (TreeNode country in continent.Nodes)
            {
                if (country.Text == name)
                {
                    treeView1.SelectedNode = country;
                    country.Expand();
                    continent.Expand();
                }
                else
                    country.Collapse();
            }
        }

        private void cityToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UserInput form = new UserInput();
            form.Confirm += new UserInput.FormAction(OnContinentFindCity);
            form.ShowDialog();
        }
        private void OnContinentFindCity(string name)
        {
            TreeNode continent = treeView1.SelectedNode;
            continent.Collapse();
            foreach (TreeNode country in continent.Nodes)
            {
                if (country.Nodes.Count != 0)
                {
                    foreach (TreeNode city in country.Nodes)
                    {
                        if (city.Text == name)
                        {
                            continent.Expand();
                            country.Expand();
                            treeView1.SelectedNode = city;
                        }
                    }
                }
            }
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UserInput form = new UserInput(treeView1.SelectedNode.Text);
            form.Confirm += new UserInput.FormAction(OnCountryEdit);
            form.ShowDialog();
        }
        private void OnCountryEdit(string name)
        {
            treeView1.SelectedNode.Text = name;
        }

        private void removeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }

        private void addCityToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UserInput form = new UserInput();
            form.Confirm += new UserInput.FormAction(OnAddCity);
            form.ShowDialog();
        }
        private void OnAddCity(string name)
        {
            TreeNode city = treeView1.SelectedNode.Nodes.Add(name);
            city.ContextMenuStrip = contextMenuCity;
        }

        private void findCityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInput form = new UserInput();
            form.Confirm += new UserInput.FormAction(OnCountryFindCity);
            form.ShowDialog();
        }
        private void OnCountryFindCity(string name)
        {
            TreeNode country = treeView1.SelectedNode;
            country.Collapse();
            foreach (TreeNode city in country.Nodes)
            {
                if (city.Text == name)
                {
                    country.Expand();
                    treeView1.SelectedNode = city;
                }
            }
        }

        private void editToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UserInput form = new UserInput(treeView1.SelectedNode.Text);
            form.Confirm += new UserInput.FormAction(OnEditCity);
            form.ShowDialog();
        }
        private void OnEditCity(string name)
        {
            treeView1.SelectedNode.Text = name;
        }

        private void removeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream file = new FileStream("earth.txt", FileMode.Create, FileAccess.Write);
            StreamWriter write = new StreamWriter(file);
            if (treeView1.Nodes.Count != 0)
                foreach (TreeNode continent in treeView1.Nodes)
                {
                    write.WriteLine(continent.Text);
                    if (continent.Nodes.Count != 0)
                        foreach (TreeNode country in continent.Nodes)
                        {
                            write.WriteLine("\t" + country.Text);
                            if (country.Nodes.Count != 0)
                                foreach (TreeNode city in country.Nodes)
                                {
                                    write.WriteLine("\t\t" + city.Text);
                                }
                        }
                }
            write.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream file;
            string input;
            try
            {
                file = new FileStream("earth.txt", FileMode.Open, FileAccess.Read);
                StreamReader read = new StreamReader(file);
                while (!read.EndOfStream)
                {
                    input = read.ReadLine();
                    if (input.StartsWith("\t\t"))
                    {
                        input = input.TrimStart('\t');
                        TreeNode node =
                            treeView1.Nodes[treeView1.Nodes.Count - 1].
                                Nodes[treeView1.Nodes[treeView1.Nodes.Count - 1].Nodes.Count - 1].
                                Nodes.Add(input);
                        node.ContextMenuStrip = contextMenuCity;
                    }
                    else if (input.StartsWith("\t"))
                    {
                        input = input.TrimStart('\t');
                        TreeNode node =
                            treeView1.Nodes[treeView1.Nodes.Count - 1].
                                Nodes.Add(input);
                        node.ContextMenuStrip = contextMenuCountry;
                    }
                    else
                    {
                        TreeNode node =
                            treeView1.Nodes.Add(input);
                        node.ContextMenuStrip = contextMenuContinent;
                    }
                }
                read.Close();
            }
            catch (FileNotFoundException)
            {
            }
        }
    }
}
