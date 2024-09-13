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
            int numeroSelecionado = Convert.ToInt32(QuantidadePicker.SelectedItem.ToString());
            int numeroSorteado = new Random().Next(1, numeroSelecionado + 1);
            ContadorLabel.Text = numeroSorteado.ToString();
        }

        //Sortear um número aleatório através do clique do botão
        //Devolver o número sorteado para a interface
        //Conseguir selecionar a quantidade de lados a partir do Picker

    }
}