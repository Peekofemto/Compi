using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compi
{
    class Lexico
    {
        public int[,] mzTransicion;
        public int edo = 0, col = 0, renglon = 1, res = 0, puntero = 0, valorMT = 0;
        public char caracter;
        public string cadena, lexema, error;
        public static List<Nodo> lista_nodos = new List<Nodo>();
        public DataGridView resultsTable;
        public Boolean final = false;

        public Lexico()
        {
           mzTransicion = new int[,]
   {
          /*      |   0|   1|   2|   3|   4|   5|   6|   7|  8 |  9 | 10 | 11 | 12 | 13 | 14 | 15 | 16 | 17 | 18 | 19 | 20 | 21 | 22 | 23 | 24 | 25 | 26 | 27 | 28 | 29 |*/ 
          /*      |   L|   D|   /|   .|   ;|   ,|   :|   =|  ( |  ) |  { |  } |  [ |  ] |  + |  - |  % |  * |  > |  < |  ! |  " |  & | |  | WS | EoL| NL | TAB| EoF| OC |*/
          /*(0)*/ {1,   2,    5,  103, 104, 105, 9,   16, 106, 107, 108, 109, 110, 111, 112, 113, 116, 117, 10,  11,  12,  13,  14,  15,  0,   0,   0,   0,   0,   506   ,},
          /*(1)*/ {1,   1,   100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100   ,},
          /*(2)*/ {101, 2,   101, 3,   101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101   ,},
          /*(3)*/ {500, 4,   500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500   ,},
          /*(4)*/ {102, 4,   102, 102, 102, 102, 102, 102, 102, 102, 102, 102, 102, 102, 102, 102, 102, 102, 102, 102, 102, 102, 102, 102, 102, 102, 102, 102, 102, 102   ,},
          /*(5)*/ {115, 115, 6,   115, 115, 115, 115, 115, 115, 115, 115, 115, 115, 115, 115, 115, 115, 7,   115, 115, 115, 115, 115, 115, 115, 115, 115, 115, 115, 115   ,},
          /*(6)*/ {6,   6,   6,   6,   6,   6,   6,   6,   6,   6,   6,   6,   6,   6,   6,   6,   6,   6,   6,   6,   6,   6,   6,   6,   6,   6,   0,   6,   6,   6     ,},
          /*(7)*/ {7,   7,   7,   7,   7,   7,   7,   7,   7,   7,   7,   7,   7,   7,   7,   7,   7,   8,   7,   7,   7,   7,   7,   7,   7,   7,   7,   7,   501, 7     ,},
          /*(8)*/ {7,   7,   0,   7,   7,   7,   7,   7,   7,   7,   7,   7,   7,   7,   7,   7,   7,   7,   7,   7,   7,   7,   7,   7,   7,   7,   7,   7,   7,   7     ,},
          /*(9)*/ {502, 502, 502, 502, 502, 502, 502, 123, 502, 502, 502, 502, 502, 502, 502, 502, 502, 502, 502, 502, 502, 502, 502, 502, 502, 502, 502, 502, 502, 502   ,},
          /*(10)*/{120, 120, 120, 120, 120, 120, 120, 122, 120, 120, 120, 120, 120, 120, 120, 120, 120, 120, 120, 120, 120, 120, 120, 120, 120, 120, 120, 120, 120, 120   ,},
          /*(11)*/{119, 119, 119, 119, 119, 119, 119, 121, 119, 119, 119, 119, 119, 119, 119, 119, 119, 119, 119, 119, 119, 119, 119, 119, 119, 119, 119, 119, 119, 119   ,},
          /*(12)*/{123, 123, 123, 123, 123, 123, 123, 118, 123, 123, 123, 123, 123, 123, 123, 123, 123, 123, 123, 123, 118, 123, 123, 123, 123, 123, 123, 123, 123, 123   ,},
          /*(13)*/{13,  13,  13,  13,  13,  13,  13,  13,  13,  13,  13,  13,  13,  13,  13,  13,  13,  13,  13,  13,  13,  124, 13,  13,  13,  13,  13,  13,  503, 13    ,},
          /*(14)*/{504, 504, 504, 504, 504, 504, 504, 504, 504, 504, 504, 504, 504, 504, 504, 504, 504, 504, 504, 504, 504, 504, 125, 504, 504, 504, 504, 504, 504, 504   ,},
          /*(15)*/{505, 505, 505, 505, 505, 505, 505, 505, 505, 505, 505, 505, 505, 505, 505, 505, 505, 505, 505, 505, 505, 505, 505, 126, 505, 505, 505, 505, 505, 505   ,}
};

        }

        public int buscarcolumna(char xcaracter)
        {
            char b = (char)32;//espacio en blanco

            switch (xcaracter)
            {
                case '/': col = 2; break;
                case '.': col = 3; break;
                case ';': col = 4; break;
                case ',': col = 5; break;
                case ':': col = 6; break;
                case '=': col = 7; break;
                case '(': col = 8; break;
                case ')': col = 9; break;
                case '{': col = 10; break;
                case '}': col = 11; break;
                case '[': col = 12; break;
                case ']': col = 13; break;
                case '+': col = 14; break;
                case '-': col = 15; break;
                case '%': col = 16; break;
                case '*': col = 17; break;
                case '>': col = 18; break;
                case '<': col = 19; break;
                case '!': col = 20; break;
                case '"': col = 21; break;
                case '&': col = 22; break;
                case '|': col = 23; break;
                case '\r': col = 25; break;
                case '\n': col = 26; renglon = renglon + 1; break;
                case '\t': col = 27; break;
                default: col = 29; break;
            }
            if (xcaracter == b) col = 24;
            if (char.IsLetter(caracter)) col = 0;
            if (char.IsDigit(caracter)) col = 1;
            if (cadena.Length == puntero) col = 28;
            return col;
        }

        public int buscarreservadas(string xlexema)
        {
            switch (xlexema)
            {
                case "package": res = 200; break;
                case "main": res = 201; break;
                case "func": res = 202; break;
                case "print": res = 203; break;
                case "scan": res = 204; break;
                case "var": res = 205; break;
                case "int": res = 206; break;
                case "string": res = 207; break;
                case "bool": res = 208; break;
                case "if": res = 209; break;
                case "else": res = 210; break;
                case "for": res = 211; break;
                case "true": res = 212; break;
                case "false": res = 213; break;
                case "break": res = 214; break;
                case "continue": res = 215; break;
                case "const": res = 216; break;
                case "type": res = 217; break;
                case "float": res = 218; break;
                default: res = valorMT; break;
            }
            return res;
        }

        public string buscarerrores(int xtoken)
        {
            switch (xtoken)
            {
                case 500: error = "Se esperaba decimal"; break;
                case 501: error = "Se esperaba cierre del comentario"; break;
                case 502: error = "Se esperaba ="; break;
                case 503: error = "Se esperaba cierre de comilla"; break;
                case 504: error = "Se esperaba &"; break;
                case 505: error = "Se esperaba |"; break;
                case 506: error = "Elemento no identificado"; break;
            }
            return error;
        }



        public void analizadorlexico()
        {
            lista_nodos.Clear();

            var lista = new Nodo();

            do
            {
                if (caracter == '\n' || caracter == '\r' || caracter == '\t')
                {
                    caracter = ' ';
                    lexema = "";
                    edo = 0;
                    puntero++;
                }


                if (valorMT == 0 && puntero > 0)
                {
                    lexema = "";
                }

                //El archivo esta vacio
                if (cadena == "") break;

                if (puntero < cadena.Length)
                {
                    caracter = cadena[puntero];
                    buscarcolumna(caracter);

                }
                else
                {
                    buscarcolumna(caracter);
                    final = false;
                }

                valorMT = mzTransicion[edo, col];

                if (valorMT < 100)
                {
                    if (caracter == '\n' || caracter == '\r' || caracter == '\t')
                    {
                        puntero++;
                        caracter = ' ';
                    }
                    else
                    {
                        edo = valorMT;
                        lexema = lexema + caracter;
                        puntero++;
                    }

                }
                else if (valorMT >= 100 && valorMT < 500)
                {
                    if (valorMT == 100)
                    {
                        valorMT = buscarreservadas(lexema);
                    }

                    /*      <=                  >=          !=               ""              :=               */
                    if (valorMT == 121 || valorMT == 122 || valorMT == 118 || valorMT == 124 || valorMT == 123 || valorMT == 129)
                    {
                        lexema = lexema + caracter;
                        puntero++;
                    }

                    if (lexema == "" || lexema == null)
                    {
                        lexema = lexema + caracter;
                        puntero++;
                    }
                    llenar_nodo();
                    lista.lexema = lexema;
                    lista.token = valorMT;
                    lista.renglon = renglon;
                    lista_nodos.Add(lista);
                    edo = 0;
                    lexema = "";
                }
                else
                {
                    if (lexema == "" || lexema == null)
                    {
                        lexema = lexema + caracter;
                    }

                }

            } while (cadena.Length >= puntero && final == false);
        }


        public void llenar_nodo()
        {

            resultsTable.Rows.Add(valorMT, lexema, renglon);

        }

    }
}
