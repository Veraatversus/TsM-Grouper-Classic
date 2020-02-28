// Decompiled with JetBrains decompiler
// Type: WindowsFormsApplication1.Form1
// Assembly: WindowsFormsApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9E4278D-47AE-470E-9EF1-D704984CCD16
// Assembly location: C:\Users\cktau\Desktop\TSM WoWhead Grouper\WindowsFormsApplication1.exe

using Awesomium.Core;
using Awesomium.Windows.Forms;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {

    public class Form1 : Form {

        #region Constructors

        public Form1() {
            InitializeComponent();
            filter.Add(new Form1.Filter() {
                Name = "1 classic",
                filter = "?filter=2;2;0"
            });
            //filter.Add(new Form1.Filter() {
            //    Name = "2 bc",
            //    filter = "?filter=cr=166:2;crs=2:2;crv=0:0"
            //});
            //filter.Add(new Form1.Filter() {
            //    Name = "3 woltk",
            //    filter = "?filter=cr=166:2;crs=3:2;crv=0:0"
            //});
            //filter.Add(new Form1.Filter() {
            //    Name = "4 cata",
            //    filter = "?filter=cr=166:2;crs=4:2;crv=0:0"
            //});
            //filter.Add(new Form1.Filter() {
            //    Name = "5 mop",
            //    filter = "?filter=cr=166:2;crs=5:2;crv=0:0"
            //});
            //filter.Add(new Form1.Filter() {
            //    Name = "6 wod",
            //    filter = "?filter=cr=166:2;crs=6:2;crv=0:0"
            //});
            //filter.Add(new Form1.Filter() {
            //    Name = "7 legion",
            //    filter = "?filter=cr=166:2;crs=7:2;crv=0:0"
            //});
            linklist.Add("http://de.wowhead.com/items=2.15");
            //linklist.Add("http://de.wowhead.com/items=2.13");
            //linklist.Add("http://de.wowhead.com/items=2.0");
            //linklist.Add("http://de.wowhead.com/items=2.4");
            //linklist.Add("http://de.wowhead.com/items=2.7");
            //linklist.Add("http://de.wowhead.com/items=2.6");
            //linklist.Add("http://de.wowhead.com/items=2.10");
            //linklist.Add("http://de.wowhead.com/items=2.1");
            //linklist.Add("http://de.wowhead.com/items=2.5");
            //linklist.Add("http://de.wowhead.com/items=2.8");
            //linklist.Add("http://de.wowhead.com/items=2.2");
            //linklist.Add("http://de.wowhead.com/items=2.18");
            //linklist.Add("http://de.wowhead.com/items=2.3");
            //linklist.Add("http://de.wowhead.com/items=2.19");
            //linklist.Add("http://de.wowhead.com/items=2.20");
            //linklist.Add("http://de.wowhead.com/items=2.14");
            //linklist.Add("http://de.wowhead.com/items=1.6");
            //linklist.Add("http://de.wowhead.com/items=1.5");
            //linklist.Add("http://de.wowhead.com/items=1.4");
            //linklist.Add("http://de.wowhead.com/items=1.2");
            //linklist.Add("http://de.wowhead.com/items=1.10");
            //linklist.Add("http://de.wowhead.com/items=1.7");
            //linklist.Add("http://de.wowhead.com/items=1.8");
            //linklist.Add("http://de.wowhead.com/items=1.1");
            //linklist.Add("http://de.wowhead.com/items=1.9");
            //linklist.Add("http://de.wowhead.com/items=1.0");
            //linklist.Add("http://de.wowhead.com/items=1.3");
            //linklist.Add("http://de.wowhead.com/items=0.8");
            //linklist.Add("http://de.wowhead.com/items=0.2.1");
            //linklist.Add("http://de.wowhead.com/items=0.2.2");
            //linklist.Add("http://de.wowhead.com/items=0.5");
            //linklist.Add("http://de.wowhead.com/items=0.3");
            //linklist.Add("http://de.wowhead.com/items=0.6");
            //linklist.Add("http://de.wowhead.com/items=0.-3");
            //linklist.Add("http://de.wowhead.com/items=0.4");
            //linklist.Add("http://de.wowhead.com/items=0.1");
            //linklist.Add("http://de.wowhead.com/items=0.7");
            //linklist.Add("http://de.wowhead.com/items=0.0");
            //linklist.Add("http://de.wowhead.com/items=16.11");
            //linklist.Add("http://de.wowhead.com/items=16.9");
            //linklist.Add("http://de.wowhead.com/items=16.3");
            //linklist.Add("http://de.wowhead.com/items=16.1");
            //linklist.Add("http://de.wowhead.com/items=16.8");
            //linklist.Add("http://de.wowhead.com/items=16.10");
            //linklist.Add("http://de.wowhead.com/items=16.2");
            //linklist.Add("http://de.wowhead.com/items=16.5");
            //linklist.Add("http://de.wowhead.com/items=16.7");
            //linklist.Add("http://de.wowhead.com/items=16.4");
            //linklist.Add("http://de.wowhead.com/items=16.6");
            //linklist.Add("http://de.wowhead.com/items=7.11");
            //linklist.Add("http://de.wowhead.com/items=7.10");
            //linklist.Add("http://de.wowhead.com/items=7.8");
            //linklist.Add("http://de.wowhead.com/items=7.3");
            //linklist.Add("http://de.wowhead.com/items=7.4");
            //linklist.Add("http://de.wowhead.com/items=7.9");
            //linklist.Add("http://de.wowhead.com/items=7.6");
            //linklist.Add("http://de.wowhead.com/items=7.13");
            //linklist.Add("http://de.wowhead.com/items=7.7");
            //linklist.Add("http://de.wowhead.com/items=7.14");
            //linklist.Add("http://de.wowhead.com/items=7.2");
            //linklist.Add("http://de.wowhead.com/items=7.5");
            //linklist.Add("http://de.wowhead.com/items=7.1");
            //linklist.Add("http://de.wowhead.com/items=7.12");
            //linklist.Add("http://de.wowhead.com/items=7.15");
            //linklist.Add("http://de.wowhead.com/items=9.6");
            //linklist.Add("http://de.wowhead.com/items=9.9");
            //linklist.Add("http://de.wowhead.com/items=9.12");
            //linklist.Add("http://de.wowhead.com/items=9.0");
            //linklist.Add("http://de.wowhead.com/items=9.7");
            //linklist.Add("http://de.wowhead.com/items=9.3");
            //linklist.Add("http://de.wowhead.com/items=9.11");
            //linklist.Add("http://de.wowhead.com/items=9.10");
            //linklist.Add("http://de.wowhead.com/items=9.5");
            //linklist.Add("http://de.wowhead.com/items=9.1");
            //linklist.Add("http://de.wowhead.com/items=9.4");
            //linklist.Add("http://de.wowhead.com/items=9.2");
            //linklist.Add("http://de.wowhead.com/items=9.8");
            //linklist.Add("http://de.wowhead.com/items=3.6");
            //linklist.Add("http://de.wowhead.com/items=3.0");
            //linklist.Add("http://de.wowhead.com/items=3.1");
            //linklist.Add("http://de.wowhead.com/items=3.2");
            //linklist.Add("http://de.wowhead.com/items=3.3");
            //linklist.Add("http://de.wowhead.com/items=3.4");
            //linklist.Add("http://de.wowhead.com/items=3.5");
            //linklist.Add("http://de.wowhead.com/items=3.8");
            //linklist.Add("http://de.wowhead.com/items=3.9");
            //linklist.Add("http://de.wowhead.com/items=3.10");
            //linklist.Add("http://de.wowhead.com/items=3.7");
            //linklist.Add("http://de.wowhead.com/items=15.3");
            //linklist.Add("http://de.wowhead.com/items=15.0");
            //linklist.Add("http://de.wowhead.com/items=15.1");
            //linklist.Add("http://de.wowhead.com/items=15.5.1");
            //linklist.Add("http://de.wowhead.com/items=15.5.2");
            //linklist.Add("http://de.wowhead.com/items=15.5.3");
            //linklist.Add("http://de.wowhead.com/items=15.2");
            //linklist.Add("http://de.wowhead.com/items=15.4");
            //linklist.Add("http://de.wowhead.com/items=12");
            //linklist.Add("http://de.wowhead.com/items=13");
            //linklist.Add("http://de.wowhead.com/items=4.1");
            //linklist.Add("http://de.wowhead.com/items=4.2");
            //linklist.Add("http://de.wowhead.com/items=4.3");
            //linklist.Add("http://de.wowhead.com/items=4.4");
            //linklist.Add("http://de.wowhead.com/items=4.-3");
            //linklist.Add("http://de.wowhead.com/items=4.-2");
            //linklist.Add("http://de.wowhead.com/items=4.-4");
            //linklist.Add("http://de.wowhead.com/items=4.-6");
            //linklist.Add("http://de.wowhead.com/items=4.-5");
            //linklist.Add("http://de.wowhead.com/items=4.6");
            //linklist.Add("http://de.wowhead.com/items=4.-8");
            //linklist.Add("http://de.wowhead.com/items=4.-7");
            //linklist.Add("http://de.wowhead.com/items=4.5");
            //linklist.Add("http://de.wowhead.com/items=4.0");
        }

        #endregion Constructors

        #region Classes

        public class Filter {

            #region Fields

            public string filter;
            public string Name;

            #endregion Fields
        }

        public class MyStruct {

            #region Public Fields

            public string Gruppenname;

            #region Fields

            public List<int> Liste = new List<int>();

            #endregion Fields

            #endregion Public Fields
        }

        #endregion Classes

        #region Methods

        protected override void Dispose(bool disposing) {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        #endregion Methods

        private Button button1;
        private Button button2;
        private IContainer components;
        private List<Form1.Filter> filter = new List<Form1.Filter>();
        private List<Form1.MyStruct> Gruppen = new List<Form1.MyStruct>();
        private HtmlWeb htmlWeb = new HtmlWeb();
        private List<string> linklist = new List<string>();
        private RichTextBox richTextBox1;
        private WebControl webControl1;

        private void Awesomium_Windows_Forms_WebControl_DocumentReady(object sender, UrlEventArgs e) {
            var str = webControl1.Source.AbsoluteUri;
            if (str.Contains("g"))
                str = str.Remove(str.IndexOf("?"));
            button1_Click();
            linklist.Remove(str);
            if (linklist.Count > 0) {
                webControl1.Source = new Uri(linklist[0]);
            }
            else {
                var num = (int)MessageBox.Show("done");
            }
        }

        private void button1_Click() {
            button1.Hide();
            var htmlDocument1 = new HtmlAgilityPack.HtmlDocument();
            htmlDocument1.LoadHtml(webControl1.ExecuteJavascriptWithResult("document.getElementsByTagName('html')[0].innerHTML"));
            var htmlNode = htmlDocument1.DocumentNode.SelectSingleNode("//meta[@name='keywords']");
            if (htmlNode != null) {
                var strArray = htmlNode.GetAttributeValue("content", "").Split(',');
                foreach (var filter in filter) {
                    var absoluteUri = webControl1.Source.AbsoluteUri;
                    if (absoluteUri.Contains("?"))
                        absoluteUri.Remove(webControl1.Source.AbsoluteUri.IndexOf("?"));
                    var htmlDocument2 = htmlWeb.Load(absoluteUri + filter.filter);
                    var myStruct1 = new Form1.MyStruct();
                    foreach (var str1 in ((IEnumerable<string>)strArray).Reverse<string>()) {
                        if (myStruct1.Gruppenname == null) {
                            myStruct1.Gruppenname = str1.Replace(" ", "");
                        }
                        else {
                            var myStruct2 = myStruct1;
                            var str2 = myStruct2.Gruppenname + "`" + str1.Replace(" ", "");
                            myStruct2.Gruppenname = str2;
                        }
                    }
                    myStruct1.Gruppenname = "group:" + myStruct1.Gruppenname + "`" + filter.Name;
                    var outerHtml = htmlDocument2.DocumentNode.OuterHtml;
                    int startIndex1;
                    for (var startIndex2 = outerHtml.IndexOf("_["); startIndex2 >= 0; startIndex2 = outerHtml.IndexOf("_[", startIndex1)) {
                        startIndex1 = outerHtml.IndexOf("]", startIndex2);
                        myStruct1.Liste.Add(Convert.ToInt32(outerHtml.Substring(startIndex2 + 2, startIndex1 - startIndex2 - 2)));
                    }
                    Gruppen.Add(myStruct1);
                }
            }
            else
                button1_Click();
            button1.Show();
        }

        private void button2_Click(object sender, EventArgs e) {
            var str = "";
            foreach (var myStruct in Gruppen) {
                if (str != "")
                    str += ",";
                str += myStruct.Gruppenname;
                foreach (var num in myStruct.Liste)
                    str = str + "," + num;
            }
            richTextBox1.Visible = !richTextBox1.Visible;
            richTextBox1.Text = str;
        }

        private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.webControl1 = new Awesomium.Windows.Forms.WebControl(this.components);
      this.button1 = new System.Windows.Forms.Button();
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.button2 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // webControl1
      // 
      this.webControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.webControl1.Location = new System.Drawing.Point(0, 0);
      this.webControl1.Size = new System.Drawing.Size(729, 532);
      this.webControl1.Source = new System.Uri("https://de.classic.wowhead.com/daggers", System.UriKind.Absolute);
      this.webControl1.TabIndex = 0;
      this.webControl1.DocumentReady += new Awesomium.Core.UrlEventHandler(this.Awesomium_Windows_Forms_WebControl_DocumentReady);
      // 
      // button1
      // 
      this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.button1.Location = new System.Drawing.Point(304, 12);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(126, 66);
      this.button1.TabIndex = 1;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // richTextBox1
      // 
      this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.richTextBox1.Location = new System.Drawing.Point(518, 0);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.Size = new System.Drawing.Size(211, 532);
      this.richTextBox1.TabIndex = 2;
      this.richTextBox1.Text = "";
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(654, 12);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 3;
      this.button2.Text = "button2";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(729, 532);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.richTextBox1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.webControl1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);

        }
    }
}