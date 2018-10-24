                       /* ## Arquivo de Execução da janela ## */
using System;              
using Gtk;      // Biblioteca da IDE monodevelop
using Cripto;   // Instanciando o arquivo Cript.cs


/* ####  Metodo padrão de execução do documento #### */

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    /* #### Objeto essencial para o funcionamento #### */

    private int x;        // x receberá a quantidade de caracteres do texto      

    /* #### Método de evento do botão cifrar #### */

    protected void OnTogglebutton1Clicked(object sender, EventArgs e)
    {
        string palavraenv, palavrarece;     // palavraenv para enviar, palavrarece para receber
        string condição = "cifrar";         // condição para o arquivo Cript.cs para cifrar ou decifrar 

        palavraenv = Convert.ToString(textview1.Buffer.Text);   // palavraenv recebe o texto da textBox1

        this.x = palavraenv.Length;         // enviando a quandidade de caracteres para o objeto x

        // palavrarece recebe o texto string retornado pelo método script da classe arqc

        palavrarece = arqc.script(palavraenv, condição, this.x);

        // imprime nas textview2 e 3 o texto retornado

        textview2.Buffer.Text = palavrarece;
        textview3.Buffer.Text = palavrarece;

    }

    /* #### Método de evento do botão decifrar #### */

    protected void OnTogglebutton2Clicked(object sender, EventArgs e)
    {
        string palavracomp, palavralimp;  // palavracomp recebe a palavra composta da textview, 
                                          // palavralimp recebe texto decifrado
        string condição = "decifrar";     // condição decifrar ao método script
       
        palavracomp = Convert.ToString(textview2.Buffer.Text); // palavracomp recebe texto composto

        // palavralimp recebe a string do método script da class arqc que retornará o texto decifrado

        palavralimp = arqc.script(palavracomp, condição, this.x);

        textview3.Buffer.Text = palavralimp; // Imprime a palavralimp na textview 3
    }
}
