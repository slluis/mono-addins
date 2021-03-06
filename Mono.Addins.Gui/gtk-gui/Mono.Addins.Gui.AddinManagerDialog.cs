
// This file has been generated by the GUI designer. Do not modify.
namespace Mono.Addins.Gui
{
	internal partial class AddinManagerDialog
	{
		private global::Gtk.VBox vbox93;

		private global::Gtk.HBox hbox85;

		private global::Gtk.Image imageInstall;

		private global::Gtk.Label label144;

		private global::Gtk.HBox hbox73;

		private global::Gtk.Label label134;

		private global::Gtk.HBox hbox65;

		private global::Gtk.HBox hbox72;

		private global::Gtk.ScrolledWindow scrolledwindow13;

		private global::Gtk.TreeView addinTree;

		private global::Gtk.VBox vbox933;

		private global::Gtk.Button btnInstall;

		private global::Gtk.Button btnRepositories;

		private global::Gtk.HSeparator hseparator4;

		private global::Gtk.Button btnUninstall;

		private global::Gtk.Button btnEnable;

		private global::Gtk.Button btnDisable;

		private global::Gtk.Button btnInfo;

		private global::Gtk.Button btnClose;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Mono.Addins.Gui.AddinManagerDialog
			this.Name = "Mono.Addins.Gui.AddinManagerDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Add-in Manager");
			this.TypeHint = ((global::Gdk.WindowTypeHint)(1));
			this.BorderWidth = ((uint)(6));
			this.DefaultWidth = 700;
			this.DefaultHeight = 550;
			// Internal child Mono.Addins.Gui.AddinManagerDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog-vbox8";
			w1.Spacing = 3;
			w1.BorderWidth = ((uint)(2));
			// Container child dialog-vbox8.Gtk.Box+BoxChild
			this.vbox93 = new global::Gtk.VBox ();
			this.vbox93.Name = "vbox93";
			this.vbox93.Spacing = 6;
			this.vbox93.BorderWidth = ((uint)(6));
			// Container child vbox93.Gtk.Box+BoxChild
			this.hbox85 = new global::Gtk.HBox ();
			this.hbox85.Name = "hbox85";
			this.hbox85.Spacing = 12;
			// Container child hbox85.Gtk.Box+BoxChild
			this.imageInstall = new global::Gtk.Image ();
			this.imageInstall.Name = "imageInstall";
			this.imageInstall.Yalign = 0f;
			this.imageInstall.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("system-software-update.png");
			this.hbox85.Add (this.imageInstall);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox85[this.imageInstall]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox85.Gtk.Box+BoxChild
			this.label144 = new global::Gtk.Label ();
			this.label144.Name = "label144";
			this.label144.LabelProp = global::Mono.Unix.Catalog.GetString ("<big><b>Add-in Manager</b></big>");
			this.label144.UseMarkup = true;
			this.hbox85.Add (this.label144);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox85[this.label144]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			this.vbox93.Add (this.hbox85);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox93[this.hbox85]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox93.Gtk.Box+BoxChild
			this.hbox73 = new global::Gtk.HBox ();
			this.hbox73.Name = "hbox73";
			this.hbox73.Spacing = 12;
			// Container child hbox73.Gtk.Box+BoxChild
			this.label134 = new global::Gtk.Label ();
			this.label134.Name = "label134";
			this.label134.Xalign = 0f;
			this.label134.LabelProp = global::Mono.Unix.Catalog.GetString ("The following add-ins are currently installed:");
			this.hbox73.Add (this.label134);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox73[this.label134]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			this.vbox93.Add (this.hbox73);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox93[this.hbox73]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox93.Gtk.Box+BoxChild
			this.hbox65 = new global::Gtk.HBox ();
			this.hbox65.Name = "hbox65";
			this.hbox65.Spacing = 12;
			// Container child hbox65.Gtk.Box+BoxChild
			this.hbox72 = new global::Gtk.HBox ();
			this.hbox72.Name = "hbox72";
			this.hbox72.Spacing = 12;
			// Container child hbox72.Gtk.Box+BoxChild
			this.scrolledwindow13 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow13.CanFocus = true;
			this.scrolledwindow13.Name = "scrolledwindow13";
			this.scrolledwindow13.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow13.Gtk.Container+ContainerChild
			this.addinTree = new global::Gtk.TreeView ();
			this.addinTree.CanFocus = true;
			this.addinTree.Name = "addinTree";
			this.scrolledwindow13.Add (this.addinTree);
			this.hbox72.Add (this.scrolledwindow13);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox72[this.scrolledwindow13]));
			w8.Position = 0;
			// Container child hbox72.Gtk.Box+BoxChild
			this.vbox933 = new global::Gtk.VBox ();
			this.vbox933.Name = "vbox933";
			this.vbox933.Spacing = 5;
			// Container child vbox933.Gtk.Box+BoxChild
			this.btnInstall = new global::Gtk.Button ();
			this.btnInstall.CanFocus = true;
			this.btnInstall.Name = "btnInstall";
			this.btnInstall.UseUnderline = true;
			// Container child btnInstall.Gtk.Container+ContainerChild
			global::Gtk.Alignment w9 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w10 = new global::Gtk.HBox ();
			w10.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w11 = new global::Gtk.Image ();
			w11.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-add", global::Gtk.IconSize.Button);
			w10.Add (w11);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w13 = new global::Gtk.Label ();
			w13.LabelProp = global::Mono.Unix.Catalog.GetString ("_Install Add-ins...");
			w13.UseUnderline = true;
			w10.Add (w13);
			w9.Add (w10);
			this.btnInstall.Add (w9);
			this.vbox933.Add (this.btnInstall);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox933[this.btnInstall]));
			w17.Position = 0;
			w17.Expand = false;
			w17.Fill = false;
			// Container child vbox933.Gtk.Box+BoxChild
			this.btnRepositories = new global::Gtk.Button ();
			this.btnRepositories.CanFocus = true;
			this.btnRepositories.Name = "btnRepositories";
			this.btnRepositories.UseUnderline = true;
			this.btnRepositories.Label = global::Mono.Unix.Catalog.GetString ("_Repositories...");
			this.vbox933.Add (this.btnRepositories);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox933[this.btnRepositories]));
			w18.Position = 1;
			w18.Expand = false;
			w18.Fill = false;
			// Container child vbox933.Gtk.Box+BoxChild
			this.hseparator4 = new global::Gtk.HSeparator ();
			this.hseparator4.Name = "hseparator4";
			this.vbox933.Add (this.hseparator4);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox933[this.hseparator4]));
			w19.Position = 2;
			w19.Expand = false;
			w19.Fill = false;
			// Container child vbox933.Gtk.Box+BoxChild
			this.btnUninstall = new global::Gtk.Button ();
			this.btnUninstall.CanFocus = true;
			this.btnUninstall.Name = "btnUninstall";
			this.btnUninstall.UseUnderline = true;
			// Container child btnUninstall.Gtk.Container+ContainerChild
			global::Gtk.Alignment w20 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w21 = new global::Gtk.HBox ();
			w21.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w22 = new global::Gtk.Image ();
			w22.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-remove", global::Gtk.IconSize.Button);
			w21.Add (w22);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w24 = new global::Gtk.Label ();
			w24.LabelProp = global::Mono.Unix.Catalog.GetString ("_Uninstall...");
			w24.UseUnderline = true;
			w21.Add (w24);
			w20.Add (w21);
			this.btnUninstall.Add (w20);
			this.vbox933.Add (this.btnUninstall);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox933[this.btnUninstall]));
			w28.Position = 3;
			w28.Expand = false;
			w28.Fill = false;
			// Container child vbox933.Gtk.Box+BoxChild
			this.btnEnable = new global::Gtk.Button ();
			this.btnEnable.CanFocus = true;
			this.btnEnable.Name = "btnEnable";
			this.btnEnable.UseUnderline = true;
			// Container child btnEnable.Gtk.Container+ContainerChild
			global::Gtk.Alignment w29 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w30 = new global::Gtk.HBox ();
			w30.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w31 = new global::Gtk.Image ();
			w31.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-yes", global::Gtk.IconSize.Button);
			w30.Add (w31);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w33 = new global::Gtk.Label ();
			w33.LabelProp = global::Mono.Unix.Catalog.GetString ("Enable");
			w33.UseUnderline = true;
			w30.Add (w33);
			w29.Add (w30);
			this.btnEnable.Add (w29);
			this.vbox933.Add (this.btnEnable);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.vbox933[this.btnEnable]));
			w37.Position = 4;
			w37.Expand = false;
			w37.Fill = false;
			// Container child vbox933.Gtk.Box+BoxChild
			this.btnDisable = new global::Gtk.Button ();
			this.btnDisable.CanFocus = true;
			this.btnDisable.Name = "btnDisable";
			this.btnDisable.UseUnderline = true;
			// Container child btnDisable.Gtk.Container+ContainerChild
			global::Gtk.Alignment w38 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w39 = new global::Gtk.HBox ();
			w39.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w40 = new global::Gtk.Image ();
			w40.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-no", global::Gtk.IconSize.Button);
			w39.Add (w40);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w42 = new global::Gtk.Label ();
			w42.LabelProp = global::Mono.Unix.Catalog.GetString ("Disable");
			w42.UseUnderline = true;
			w39.Add (w42);
			w38.Add (w39);
			this.btnDisable.Add (w38);
			this.vbox933.Add (this.btnDisable);
			global::Gtk.Box.BoxChild w46 = ((global::Gtk.Box.BoxChild)(this.vbox933[this.btnDisable]));
			w46.Position = 5;
			w46.Expand = false;
			w46.Fill = false;
			// Container child vbox933.Gtk.Box+BoxChild
			this.btnInfo = new global::Gtk.Button ();
			this.btnInfo.CanFocus = true;
			this.btnInfo.Name = "btnInfo";
			this.btnInfo.UseStock = true;
			this.btnInfo.UseUnderline = true;
			this.btnInfo.Label = "gtk-dialog-info";
			this.vbox933.Add (this.btnInfo);
			global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(this.vbox933[this.btnInfo]));
			w47.Position = 6;
			w47.Expand = false;
			w47.Fill = false;
			this.hbox72.Add (this.vbox933);
			global::Gtk.Box.BoxChild w48 = ((global::Gtk.Box.BoxChild)(this.hbox72[this.vbox933]));
			w48.Position = 1;
			w48.Expand = false;
			w48.Fill = false;
			this.hbox65.Add (this.hbox72);
			global::Gtk.Box.BoxChild w49 = ((global::Gtk.Box.BoxChild)(this.hbox65[this.hbox72]));
			w49.Position = 0;
			this.vbox93.Add (this.hbox65);
			global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(this.vbox93[this.hbox65]));
			w50.Position = 2;
			w1.Add (this.vbox93);
			global::Gtk.Box.BoxChild w51 = ((global::Gtk.Box.BoxChild)(w1[this.vbox93]));
			w51.Position = 0;
			// Internal child Mono.Addins.Gui.AddinManagerDialog.ActionArea
			global::Gtk.HButtonBox w52 = this.ActionArea;
			w52.Name = "dialog-action_area8";
			w52.Spacing = 6;
			w52.BorderWidth = ((uint)(5));
			w52.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog-action_area8.Gtk.ButtonBox+ButtonBoxChild
			this.btnClose = new global::Gtk.Button ();
			this.btnClose.CanDefault = true;
			this.btnClose.CanFocus = true;
			this.btnClose.Name = "btnClose";
			this.btnClose.UseStock = true;
			this.btnClose.UseUnderline = true;
			this.btnClose.Label = "gtk-close";
			this.AddActionWidget (this.btnClose, -7);
			global::Gtk.ButtonBox.ButtonBoxChild w53 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w52[this.btnClose]));
			w53.Expand = false;
			w53.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
			this.addinTree.CursorChanged += new global::System.EventHandler (this.OnSelectionChanged);
			this.btnInstall.Clicked += new global::System.EventHandler (this.OnInstall);
			this.btnRepositories.Clicked += new global::System.EventHandler (this.OnManageRepos);
			this.btnUninstall.Clicked += new global::System.EventHandler (this.OnUninstall);
			this.btnEnable.Clicked += new global::System.EventHandler (this.OnEnable);
			this.btnDisable.Clicked += new global::System.EventHandler (this.OnDisable);
			this.btnInfo.Clicked += new global::System.EventHandler (this.OnShowInfo);
		}
	}
}
