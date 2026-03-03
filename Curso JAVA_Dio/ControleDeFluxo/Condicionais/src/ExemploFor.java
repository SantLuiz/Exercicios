public class ExemploFor {
    
    public static void main(String[] args) throws Exception {
        String alunos [] ={"João", "José", "Mario", "Josefa"};

       for (String x:alunos){
        if (x == "Mario")
            continue;
            
        System.out.println("Nome do aluno é:" + x);

       };

       for (int x = 0; x<=10; x++){
        System.out.println(x + " Carneirinho contado!" );
       }
    }
}
