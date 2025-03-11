class Calculator
{
	static void Main (string[]args)
	{
		int a= 10;
		int b=6; 
		
		console.Writeline("haail penambahan: {0} + {1} ={2}",a,b,penambahan(a,b));
		console.Writeline("haail pengurangan : {0} - {1} ={2}",a,b,pengurangan(a,b));
		
		console.Writeline("\nTekan sembarang key untuk keluar ");
		console.Readkey();
		
	}
	static int penambahan (int a, int b)
	{
		return a+b;
	}
	static int pengurangan (int a, int b)
	{
	return a-b ;
	}	
	
}	
