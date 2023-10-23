public class Contract : IContract
{
    public int Number, Installments;
    public double ValueI, ValueM, ValueFull, ValueF, Percentage;
    public DateTime Date;
    public bool Verify = true;
    public string? input, DateOnly;
    public void Get()
    {
        Console.WriteLine("Entre com os dados do Contrato");
        Console.Write("Número do contrato:");
        Number = Convert.ToInt32(Console.ReadLine());
        while(Verify){
            Console.Write("Data do contrato (dd/mm/yyyy):");
            input = Console.ReadLine();
            if (DateTime.TryParseExact(input, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out Date))
            {
                Verify = false; 
            }
            else
            {
                Console.WriteLine("Formato inválido! Digite da forma correta.");
            }
        }
        Console.Write("Valor do contrato:");
        ValueFull = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite a quantidade de parcelas:");
        Installments = Convert.ToInt32(Console.ReadLine());
        DateOnly = Date.ToShortDateString();
    }

    public void Show()
    {
        Console.WriteLine("Parcelas:");
        for (int i = 1; i<=Installments; i++){
            ValueI = ValueFull / Installments;
            Date = Date.AddMonths(1);
            DateOnly = Date.ToShortDateString();
            Percentage = 1 * i;
            ValueM = Percentage/100 * ValueI + ValueI;
            Percentage = 2;
            ValueF = Percentage/100 * ValueM + ValueM;
            Console.WriteLine($"{DateOnly} - {ValueF}");
        }
        Console.WriteLine("--------------------------------------------------------------------");
        Console.WriteLine("Calculos (1% de juros simples por mês + 2% de taxa de pagamento):");
        for (int f = 1; f<=Installments; f++){
            Console.WriteLine($"Parcela #{f}");
            Percentage = 1 * f;
            ValueM = Percentage/100 * ValueI + ValueI;
            Console.WriteLine($"{ValueI} + 1% * {f} = {ValueM}");
            Percentage = 2;
            ValueF = Percentage/100 * ValueM + ValueM;
            Console.WriteLine($"{ValueM} + 2% = {ValueF}");
        }
    }
}