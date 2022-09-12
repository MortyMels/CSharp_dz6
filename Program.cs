bool r = true; //Число в степени dz5-1 dz6
Console.Clear();
    
while(r){
    Console.WriteLine("Введите набор из двух чисел в формате '0, 0'");
    string s = Console.ReadLine().Replace(" ", "");;
    //string[] sa = s.Split(';',',', ' ');
    int[] cl;
    //foreach (var san in sa)
    //{
        cl=StrToIntAr(s,true);//Вводим размерность массива

        if((cl.Length-1==2)){
            if(cl[0]==0){

                int[][] arr = new int[cl[1]][];
                int[] arrs = new int[cl[2]];
                for (int i = 0; i < cl[1]; i++){
                    arr[i] = new int[cl[2]];
                    for (int ii = 0; ii < cl[2]; ii++){
                        arr[i][ii]= new Random().Next(0,999); //Генерируем число
                        arrs[ii]+=arr[i][ii];
                    }
                    Array.Sort(arr[i]);
                    Array.Reverse(arr[i]);
                }

                Console.WriteLine($"Массив из {cl[1]}x{cl[2]} чисел");
                
                Console.Write($"Среднее арифметическое столбцов: ");
                foreach(var arrsi in arrs){
                    Console.Write($"{arrsi/cl[1]}, ");
                }
                Console.WriteLine($"");
                Console.WriteLine($"-----");


                bool r2 = true;
                while(r2){
                    Console.WriteLine("Введите набор из двух чисел в формате '0, 0'");
                    string s2 = Console.ReadLine().Replace(" ", "");
                    
                    cl=StrToIntAr(s2,true);//Вводим размерность массива

                    if((cl.Length-1==2)){
                        if(cl[0]==0){
                            try{
                                Console.WriteLine($"Элемент массива на строке {cl[1]} в столбце {cl[2]}: {arr[cl[1]-1][cl[2]-1]}");
                            }catch{
                                Console.WriteLine($"Введен неверный адрес числа {s2}");
                            }

                        }
                    }else{
                        Console.WriteLine($"Неверное количество параметров в наборе чисел: {s2}");
                    }
                    if (s2=="end"){
                        r2=false;
                    }
                }
            }
        }else{
            Console.WriteLine($"Неверное количество параметров в наборе чисел: {s}");
        }
    //}
    if (s=="end"){
        r=false;
    }
    
}

int[] StrToIntAr(string str, bool err) {
    string[] stra = str.Split(',','*','x','X');
    int[] numa = new int [stra.Length+1];
    int i = 0;
    foreach (string strai in stra){
        if(!int.TryParse(strai, out numa[++i])){
            if(err){
                Console.WriteLine($"Нераспознан {i} элемента набора '{strai}' в: {str}");
            }
            numa[0]++;
        }
    }
    return numa;
}