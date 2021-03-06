
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;

	private global::Gtk.ToggleButton togglebutton1;

	private global::Gtk.Image image3;

	private global::Gtk.Image image4;

	private global::Gtk.ToggleButton togglebutton2;

	private global::Gtk.Image image5;

	private global::Gtk.Label label1;

	private global::Gtk.Label label2;

	private global::Gtk.Label label3;

	private global::Gtk.ScrolledWindow GtkScrolledWindow;

	private global::Gtk.TextView textview1;

	private global::Gtk.ScrolledWindow GtkScrolledWindow1;

	private global::Gtk.TextView textview2;

	private global::Gtk.ScrolledWindow GtkScrolledWindow2;

	private global::Gtk.TextView textview3;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("Mensagem");
		this.Icon = global::Stetic.IconLoader.LoadIcon(this, "stock_mail-reply", global::Gtk.IconSize.Menu);
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.togglebutton1 = new global::Gtk.ToggleButton();
		this.togglebutton1.WidthRequest = 100;
		this.togglebutton1.CanFocus = true;
		this.togglebutton1.Name = "togglebutton1";
		this.togglebutton1.UseUnderline = true;
		this.togglebutton1.Inconsistent = true;
		this.togglebutton1.Label = global::Mono.Unix.Catalog.GetString("cifrar");
		global::Gtk.Image w1 = new global::Gtk.Image();
		w1.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "stock_lock", global::Gtk.IconSize.Menu);
		this.togglebutton1.Image = w1;
		this.fixed1.Add(this.togglebutton1);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.togglebutton1]));
		w2.X = 327;
		w2.Y = 169;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.image3 = new global::Gtk.Image();
		this.image3.Name = "image3";
		this.image3.Pixbuf = new global::Gdk.Pixbuf(global::System.IO.Path.Combine(global::System.AppDomain.CurrentDomain.BaseDirectory, "./pessoa.png"));
		this.fixed1.Add(this.image3);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.image3]));
		w3.X = 311;
		w3.Y = 28;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.image4 = new global::Gtk.Image();
		this.image4.Name = "image4";
		this.image4.Pixbuf = new global::Gdk.Pixbuf(global::System.IO.Path.Combine(global::System.AppDomain.CurrentDomain.BaseDirectory, "./pessoa.png"));
		this.fixed1.Add(this.image4);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.image4]));
		w4.X = 314;
		w4.Y = 283;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.togglebutton2 = new global::Gtk.ToggleButton();
		this.togglebutton2.WidthRequest = 100;
		this.togglebutton2.CanFocus = true;
		this.togglebutton2.Name = "togglebutton2";
		this.togglebutton2.UseUnderline = true;
		this.togglebutton2.Inconsistent = true;
		this.togglebutton2.Label = global::Mono.Unix.Catalog.GetString("Decifrar");
		global::Gtk.Image w5 = new global::Gtk.Image();
		w5.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "stock_keyring", global::Gtk.IconSize.Menu);
		this.togglebutton2.Image = w5;
		this.fixed1.Add(this.togglebutton2);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.togglebutton2]));
		w6.X = 326;
		w6.Y = 420;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.image5 = new global::Gtk.Image();
		this.image5.Name = "image5";
		this.image5.Pixbuf = new global::Gdk.Pixbuf(global::System.IO.Path.Combine(global::System.AppDomain.CurrentDomain.BaseDirectory, "./seta.png"));
		this.fixed1.Add(this.image5);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.image5]));
		w7.X = 335;
		w7.Y = 198;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label1 = new global::Gtk.Label();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Enviando mensagem ao usuário secundário \nde forma segura");
		this.fixed1.Add(this.label1);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label1]));
		w8.X = 20;
		w8.Y = 9;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label2 = new global::Gtk.Label();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Texto Criptografado :");
		this.fixed1.Add(this.label2);
		global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label2]));
		w9.X = 16;
		w9.Y = 172;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label3 = new global::Gtk.Label();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Conversão de texto cifrado para decifrado :");
		this.fixed1.Add(this.label3);
		global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label3]));
		w10.X = 17;
		w10.Y = 303;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.VscrollbarPolicy = ((global::Gtk.PolicyType)(0));
		this.GtkScrolledWindow.HscrollbarPolicy = ((global::Gtk.PolicyType)(2));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.textview1 = new global::Gtk.TextView();
		this.textview1.WidthRequest = 260;
		this.textview1.HeightRequest = 110;
		this.textview1.CanFocus = true;
		this.textview1.WrapMode = ((global::Gtk.WrapMode)(1));
		this.GtkScrolledWindow.Add(this.textview1);
		this.fixed1.Add(this.GtkScrolledWindow);
		global::Gtk.Fixed.FixedChild w12 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.GtkScrolledWindow]));
		w12.X = 16;
		w12.Y = 59;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
		this.GtkScrolledWindow1.VscrollbarPolicy = ((global::Gtk.PolicyType)(0));
		this.GtkScrolledWindow1.HscrollbarPolicy = ((global::Gtk.PolicyType)(2));
		// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
		this.textview2 = new global::Gtk.TextView();
		this.textview2.WidthRequest = 260;
		this.textview2.HeightRequest = 110;
		this.textview2.CanFocus = true;
		this.textview2.Name = "textview2";
		this.textview2.WrapMode = ((global::Gtk.WrapMode)(1));
		this.GtkScrolledWindow1.Add(this.textview2);
		this.fixed1.Add(this.GtkScrolledWindow1);
		global::Gtk.Fixed.FixedChild w14 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.GtkScrolledWindow1]));
		w14.X = 15;
		w14.Y = 189;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.GtkScrolledWindow2 = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow2.Name = "GtkScrolledWindow2";
		this.GtkScrolledWindow2.VscrollbarPolicy = ((global::Gtk.PolicyType)(0));
		this.GtkScrolledWindow2.HscrollbarPolicy = ((global::Gtk.PolicyType)(2));
		// Container child GtkScrolledWindow2.Gtk.Container+ContainerChild
		this.textview3 = new global::Gtk.TextView();
		this.textview3.WidthRequest = 260;
		this.textview3.HeightRequest = 110;
		this.textview3.CanFocus = true;
		this.textview3.Name = "textview3";
		this.textview3.WrapMode = ((global::Gtk.WrapMode)(1));
		this.GtkScrolledWindow2.Add(this.textview3);
		this.fixed1.Add(this.GtkScrolledWindow2);
		global::Gtk.Fixed.FixedChild w16 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.GtkScrolledWindow2]));
		w16.X = 16;
		w16.Y = 324;
		this.Add(this.fixed1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 503;
		this.DefaultHeight = 467;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.togglebutton1.Clicked += new global::System.EventHandler(this.OnTogglebutton1Clicked);
		this.togglebutton2.Clicked += new global::System.EventHandler(this.OnTogglebutton2Clicked);
	}
}
