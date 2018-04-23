using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Reflection;
using DevExpress.XtraNavBar;
using DevExpress.XtraNavBar.ViewInfo;

namespace WindowsApplication29
{
  /// <summary>
  /// Summary description for Form1.
  /// </summary>
  public class Form1 : System.Windows.Forms.Form
  {
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraNavBar.NavBarItem navBarItem6;
        private DevExpress.XtraNavBar.NavBarItem navBarItem7;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem8;
        private DevExpress.XtraNavBar.NavBarItem navBarItem9;
        private DevExpress.XtraNavBar.NavBarItem navBarItem10;
        private DevExpress.XtraNavBar.NavBarItem navBarItem11;
        private Panel panel1;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.Container components = null;

    public Form1()
    {
      //
      // Required for Windows Form Designer support
      //
      InitializeComponent();

      //
      // TODO: Add any constructor code after InitializeComponent call
      //
    }

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    protected override void Dispose( bool disposing )
    {
      if( disposing )
      {
        if (components != null) 
        {
          components.Dispose();
        }
      }
      base.Dispose( disposing );
    }

    #region Windows Form Designer generated code
    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
        this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
        this.navBarItem10 = new DevExpress.XtraNavBar.NavBarItem();
        this.navBarGroupControlContainer1 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
        this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
        this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
        this.navBarItem6 = new DevExpress.XtraNavBar.NavBarItem();
        this.navBarItem7 = new DevExpress.XtraNavBar.NavBarItem();
        this.navBarItem8 = new DevExpress.XtraNavBar.NavBarItem();
        this.navBarItem9 = new DevExpress.XtraNavBar.NavBarItem();
        this.navBarItem11 = new DevExpress.XtraNavBar.NavBarItem();
        this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
        this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
        this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
        this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
        this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
        this.panel1 = new System.Windows.Forms.Panel();
        ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
        this.navBarControl1.SuspendLayout();
        this.navBarGroupControlContainer1.SuspendLayout();
        this.SuspendLayout();
        // 
        // navBarControl1
        // 
        this.navBarControl1.ActiveGroup = this.navBarGroup1;
        this.navBarControl1.ContentButtonHint = null;
        this.navBarControl1.Controls.Add(this.navBarGroupControlContainer1);
        this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Right;
        this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3});
        this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem1,
            this.navBarItem2,
            this.navBarItem3,
            this.navBarItem4,
            this.navBarItem5,
            this.navBarItem6,
            this.navBarItem7,
            this.navBarItem8,
            this.navBarItem9,
            this.navBarItem10,
            this.navBarItem11});
        this.navBarControl1.Location = new System.Drawing.Point(344, 0);
        this.navBarControl1.LookAndFeel.SkinName = "Liquid Sky";
        this.navBarControl1.LookAndFeel.UseDefaultLookAndFeel = false;
        this.navBarControl1.Name = "navBarControl1";
        this.navBarControl1.OptionsNavPane.ExpandedWidth = 280;
        this.navBarControl1.Size = new System.Drawing.Size(280, 374);
        this.navBarControl1.TabIndex = 0;
        this.navBarControl1.Text = "navBarControl1";
        // 
        // navBarGroup1
        // 
        this.navBarGroup1.Caption = "navBarGroup1";
        this.navBarGroup1.Expanded = true;
        this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem10)});
        this.navBarGroup1.Name = "navBarGroup1";
        // 
        // navBarItem10
        // 
        this.navBarItem10.Caption = "navBarItem10";
        this.navBarItem10.Name = "navBarItem10";
        // 
        // navBarGroupControlContainer1
        // 
        this.navBarGroupControlContainer1.Controls.Add(this.panel1);
        this.navBarGroupControlContainer1.ForeColor = System.Drawing.Color.Transparent;
        this.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1";
        this.navBarGroupControlContainer1.Size = new System.Drawing.Size(276, 78);
        this.navBarGroupControlContainer1.TabIndex = 2;
        // 
        // navBarGroup2
        // 
        this.navBarGroup2.Caption = "navBarGroup2";
        this.navBarGroup2.Expanded = true;
        this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem5),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem6),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem7),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem8),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem9),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem11)});
        this.navBarGroup2.Name = "navBarGroup2";
        // 
        // navBarItem5
        // 
        this.navBarItem5.Caption = "navBarItem5";
        this.navBarItem5.Name = "navBarItem5";
        // 
        // navBarItem6
        // 
        this.navBarItem6.Caption = "navBarItem6";
        this.navBarItem6.Name = "navBarItem6";
        // 
        // navBarItem7
        // 
        this.navBarItem7.Caption = "navBarItem7";
        this.navBarItem7.Name = "navBarItem7";
        // 
        // navBarItem8
        // 
        this.navBarItem8.Caption = "navBarItem8";
        this.navBarItem8.Name = "navBarItem8";
        // 
        // navBarItem9
        // 
        this.navBarItem9.Caption = "navBarItem9";
        this.navBarItem9.Name = "navBarItem9";
        // 
        // navBarItem11
        // 
        this.navBarItem11.Caption = "navBarItem11";
        this.navBarItem11.Name = "navBarItem11";
        // 
        // navBarGroup3
        // 
        this.navBarGroup3.Caption = "navBarGroup3";
        this.navBarGroup3.ControlContainer = this.navBarGroupControlContainer1;
        this.navBarGroup3.Expanded = true;
        this.navBarGroup3.GroupClientHeight = 80;
        this.navBarGroup3.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
        this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem3),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem4)});
        this.navBarGroup3.Name = "navBarGroup3";
        this.navBarGroup3.CalcGroupClientHeight += new DevExpress.XtraNavBar.NavBarCalcGroupClientHeightEventHandler(this.navBarGroup3_CalcGroupClientHeight);
        // 
        // navBarItem1
        // 
        this.navBarItem1.Caption = "navBarItem1";
        this.navBarItem1.Name = "navBarItem1";
        // 
        // navBarItem2
        // 
        this.navBarItem2.Caption = "navBarItem2";
        this.navBarItem2.Name = "navBarItem2";
        // 
        // navBarItem3
        // 
        this.navBarItem3.Caption = "navBarItem3";
        this.navBarItem3.Name = "navBarItem3";
        // 
        // navBarItem4
        // 
        this.navBarItem4.Caption = "navBarItem4";
        this.navBarItem4.Name = "navBarItem4";
        // 
        // panel1
        // 
        this.panel1.BackColor = System.Drawing.Color.Red;
        this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.panel1.ForeColor = System.Drawing.Color.Transparent;
        this.panel1.Location = new System.Drawing.Point(0, 0);
        this.panel1.Name = "panel1";
        this.panel1.Size = new System.Drawing.Size(276, 78);
        this.panel1.TabIndex = 0;
        // 
        // Form1
        // 
        this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
        this.ClientSize = new System.Drawing.Size(624, 374);
        this.Controls.Add(this.navBarControl1);
        this.Name = "Form1";
        this.Text = "Form1";
        this.Load += new System.EventHandler(this.Form1_Load);
        ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
        this.navBarControl1.ResumeLayout(false);
        this.navBarGroupControlContainer1.ResumeLayout(false);
        this.ResumeLayout(false);

    }
    #endregion

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() 
    {
      Application.Run(new Form1());
    }

        private NavBarViewInfo GetViewInfo(NavBarControl navBar) {
            FieldInfo fi = typeof(NavBarControl).GetField("viewInfo", BindingFlags.NonPublic | BindingFlags.Instance);
            return fi.GetValue(navBar) as NavBarViewInfo;
        }

        private ExplorerBarNavGroupPainter GetGroupPainter(NavBarControl navBar) {
            FieldInfo fi = typeof(NavBarControl).GetField("groupPainter", BindingFlags.NonPublic | BindingFlags.Instance);
            return fi.GetValue(navBar) as ExplorerBarNavGroupPainter;
        }

        private void Form1_Load(object sender, System.EventArgs e) {
        }

        private void navBarGroup3_CalcGroupClientHeight(object sender, DevExpress.XtraNavBar.NavBarCalcGroupClientHeightEventArgs e) {
            NavBarViewInfo vi = GetViewInfo(navBarControl1);
            NavGroupInfoArgs gi = vi.Groups[vi.Groups.Count - 1] as NavGroupInfoArgs;
            ExplorerBarNavGroupPainter groupPainter = GetGroupPainter(navBarControl1);
            groupPainter.CalcFooterBounds(gi, gi.Bounds, gi.ButtonBounds.Size);
            int delta = gi.Bounds.Top - vi.Client.Top;
            int ch = vi.Client.Height - delta - gi.Bounds.Height - gi.FooterBounds.Height; 
            e.Height = ch;
        }
  }
}
