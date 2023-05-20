using System;
namespace homework{
    class program {
        static void Main(string[]args){
            int row;
            int col;
            do{
            int rowNumber = int.Parse(Console.ReadLine());
            if(rowNumber < 0){
                Console.WriteLine("Invalid Pascal’s triangle row number.");
                continue;
            } 
            PrintPascalTriangle(rowNumber);
            break;
            }while(true);
        }
        static int CalculatePascal(int row,int col){
            if(col == 0 || col == row){
                return 1;
            }else {
                return CalculatePascal(row - 1, col - 1) + CalculatePascal(row - 1, col);
            }
        }
        static void PrintPascalTriangle(int rowNumber) {
            for (int i = 0; i <= rowNumber; i++){
                for (int j = 0; j <= i; j++){
                    Console.Write(CalculatePascal(i, j) + " ");
                }
            Console.WriteLine();
            }
        }
    }
}