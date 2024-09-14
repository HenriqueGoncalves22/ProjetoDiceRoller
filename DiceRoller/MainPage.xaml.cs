namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void SortearButton_Clicked(object sender, EventArgs e)
        {
            int quantidadeDeDado = 0;
            int soma = 0;
            int modificador = 0;
            int numeroSelecionado = Convert.ToInt32(QuantidadePicker.SelectedItem.ToString());
            modificador = Convert.ToInt32(ModificadorPicker.SelectedItem.ToString());
            quantidadeDeDado = Convert.ToInt32(QuantidadeEntry.Text);
            for (int i = 0; i < 3; i++)
            {
                int numeroSorteado = new Random().Next(1, numeroSelecionado + 1);
                soma = numeroSorteado;
                soma += soma + modificador;   
            }
            ContadorLabel.Text = soma.ToString();
        }

        


        /*
        class Dado
        {
            private int quantidadeDeLados;
            private int modificador;

            public Dado() { }
            
            public int RolarDado(object sender, EventArgs e)
                {
              
                }
            public int GetModificador() {
                return modificador;
        }*/


        //Sortear um número aleatório através do clique do botão
        //Devolver o número sorteado para a interface
        //Conseguir selecionar a quantidade de lados a partir do Picker

    }
}