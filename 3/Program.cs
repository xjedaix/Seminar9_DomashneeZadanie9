// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using System;

class MainClass {
  public static int Ackermann(int m, int n) {
    if (m == 0) {
      return n + 1;
    }
    else if (n == 0) {
      return Ackermann(m - 1, 1);
    }
    else {
      return Ackermann(m - 1, Ackermann(m, n - 1));
    }
  }

  public static void Main (string[] args) {
    int m = 2;
    int n = 3;
    Console.WriteLine("A({0}, {1}) = {2}", m, n, Ackermann(m, n));

    m = 3;
    n = 2;
    Console.WriteLine("A({0}, {1}) = {2}", m, n, Ackermann(m, n));
  }
}