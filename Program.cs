//исходный массиы
string[] str = {"q", "qw", "qwe","w", "w2", "wty","qwerty", "ty", "y","", "y", "y444", "y444"};
               // {"q", "qw"};
               //{};
               //{"q123","q123"};

int j = 0;
for (int i = 0; i < str.Length; i++){
   if (str[i].Length >= 3) {
      str[j] = str[i];
      j++;
      
   }  
}

string[] str_new = new string[j]; // новый массив, состоящий из элементов исходного, длина которых не меньше 3 символов
for (int i = 0; i < j; i++){
   str_new[i] = str[i];  
   Console.WriteLine(str_new[i]); // вывожу его в этом же цикле
}