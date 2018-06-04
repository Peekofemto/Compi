using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Compi
{
    public class Sintactico
    {

        public static List<Nodo> lista_nodos;
        public int puntero = 0;
        public DataGridView Errores;

        public Sintactico(List<Nodo> lista)
        {
            lista_nodos = lista;
        }


        public void analizador()
        {
            try
            {
                while (lista_nodos.Count > puntero)
                {
                    //package
                    if (lista_nodos[puntero].token == 200)
                    {
                        puntero++;

                        //main
                        if (lista_nodos[puntero].token == 201)
                        {
                            puntero++;

                            //func
                            if (lista_nodos[puntero].token == 202)
                            {
                                puntero++;

                                //main
                                if (lista_nodos[puntero].token == 201)
                                {
                                    puntero++;

                                    //(
                                    if (lista_nodos[puntero].token == 106)
                                    {
                                        puntero++;

                                        //)
                                        if (lista_nodos[puntero].token == 107)
                                        {
                                            puntero++;
                                            puntero = Bloque();
                                        }
                                        else
                                        {
                                            LlenarFallaSintaxis();
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        LlenarFallaSintaxis();
                                        break;
                                    }
                                }
                                else
                                {
                                    LlenarFallaSintaxis();
                                    break;
                                }
                            }
                            else
                            {
                                LlenarFallaSintaxis();
                                break;
                            }
                        }
                        else
                        {
                            LlenarFallaSintaxis();
                            break;
                        }
                    }
                    else
                    {
                        LlenarFallaSintaxis();
                        break;
                    }
                }
            }
            catch
            {
                BuscarFallaSintaxis();

            }
        }





        public int Bloque()
        {
            try
            {
                //{
                if (lista_nodos[puntero].token == 108)
                {
                    puntero++;
                    puntero = Statement_list();

                    //}
                    if (lista_nodos[puntero].token == 109)
                    {
                        puntero++;
                        MessageBox.Show("Análisis completado con exito");
                    }
                    else
                    {
                        LlenarFallaSintaxis();
                    }

                }
                else
                {
                    LlenarFallaSintaxis();
                }
            }
            catch
            {
                BuscarFallaSintaxis();
            }
            return puntero;
        }

        public int Statement_list()
        {
            try
            {
                /*             identificador                           if                              print                        scan           */
                if (lista_nodos[puntero].token == 100 || lista_nodos[puntero].token == 209 || lista_nodos[puntero].token == 203 || lista_nodos[puntero].token == 204 || lista_nodos[puntero].token == 211 || lista_nodos[puntero].token == 210 || lista_nodos[puntero].token == 101 || lista_nodos[puntero].token == 102)
                {
                    puntero = Statement();
                }
            }
            catch
            {
                BuscarFallaSintaxis();
            }
            return puntero;
        }

        public int Statement()
        {
            try
            {
                /*             identificador                           if                              print                        scan                            else */
                while (lista_nodos[puntero].token == 100 || lista_nodos[puntero].token == 209 || lista_nodos[puntero].token == 203 || lista_nodos[puntero].token == 204 || lista_nodos[puntero].token == 210 || lista_nodos[puntero].token == 101 || lista_nodos[puntero].token == 102 || lista_nodos[puntero].token == 211)
                {
                    //Declaracion de la variable
                    if (lista_nodos[puntero].token == 100)
                    {
                        puntero = vardec();
                    }
                    //if
                    else if (lista_nodos[puntero].token == 209)
                    {
                        puntero = EsIf();

                    }
                    //else
                    else if (lista_nodos[puntero].token == 210)
                    {
                        puntero = EsElse();
                    }
                    //print
                    else if (lista_nodos[puntero].token == 203)
                    {
                        puntero = EsPrint();
                    }
                    //scan
                    else if (lista_nodos[puntero].token == 204)
                    {
                        puntero = EsScan();
                    }
                    //for
                    else if (lista_nodos[puntero].token == 211)
                    {
                        puntero = EsFor();
                    }
                    else if (lista_nodos[puntero].token == 101 || lista_nodos[puntero].token == 102) ;
                    {
                        puntero = exp_num();
                    }

                }
            }
            catch
            {
                LlenarFallaSintaxis();
            }
            return puntero;
        }

        public int vardec()
        {
            try
            { //id
                if (lista_nodos[puntero].token == 100)
                {
                    puntero++;
                    //:=
                    if (lista_nodos[puntero].token == 123)
                    {
                        puntero++;
                        //Un ID                               ó     un número entero                ó     un número decimal             ó      un string                     ó   un True                           ó    un False
                        if (lista_nodos[puntero].token == 100 || lista_nodos[puntero].token == 101 || lista_nodos[puntero].token == 102 || lista_nodos[puntero].token == 124 || lista_nodos[puntero].token == 212 || lista_nodos[puntero].token == 213)
                        {
                            puntero++;
                        }
                        else
                        {
                            LlenarFallaSintaxis();
                        }

                    }
                    else
                    {
                        LlenarFallaSintaxis();
                    }
                }
                else
                {
                    LlenarFallaSintaxis();
                }
            }
            catch
            {
                BuscarFallaSintaxis();
            }
            return puntero;
        }

        public int EsIf()
        {
            try
            {
                // If
                if (lista_nodos[puntero].token == 209)
                {
                    puntero++;
                    //(
                    if (lista_nodos[puntero].token == 106)
                    {
                        puntero++;
                        puntero = exp_rel();


                        //)
                        if (lista_nodos[puntero].token == 107)
                        {
                            puntero++;

                            //{
                            if (lista_nodos[puntero].token == 108)
                            {
                                puntero++;
                                Statement();

                                //}
                                if (lista_nodos[puntero].token == 109)
                                {
                                    puntero++;
                                }
                                else
                                {
                                    LlenarFallaSintaxis();
                                }
                            }
                            else
                            {
                                LlenarFallaSintaxis();
                            }
                        }
                        else
                        {
                            LlenarFallaSintaxis();
                        }

                    }
                    else
                    {
                        LlenarFallaSintaxis();
                    }
                }
                else
                {
                    LlenarFallaSintaxis();
                }
            }
            catch
            {
                BuscarFallaSintaxis();
            }
            return puntero;
        }

        public int EsFor()
        {
            try
            {
                if (lista_nodos[puntero].token == 211) //for
                {
                    puntero++;
                    if (lista_nodos[puntero].token == 106) //(
                    {
                        puntero++;
                        if (lista_nodos[puntero].token == 100) //ID
                        {
                            puntero++;
                            if (lista_nodos[puntero].token == 123) //:=
                            {
                                puntero++;
                                puntero = exp_num();
                                if (lista_nodos[puntero].token == 104) //;
                                {
                                    puntero++;
                                    if (lista_nodos[puntero].token == 100) //ID
                                    {
                                        puntero++;
                                        if (lista_nodos[puntero].token == 119 || lista_nodos[puntero].token == 120 || lista_nodos[puntero].token == 121 || lista_nodos[puntero].token == 122) // op_rel
                                        {
                                            puntero++;
                                            puntero = op_rel();

                                            if (lista_nodos[puntero].token == 101 || lista_nodos[puntero].token == 102) //valor_num
                                            {
                                                puntero++;
                                                puntero = valor_num();

                                                if (lista_nodos[puntero].token == 104) //;
                                                {
                                                    puntero++;
                                                    if (lista_nodos[puntero].token == 100) //ID
                                                    {
                                                        puntero++;
                                                        if (lista_nodos[puntero].token == 112) //+
                                                        {
                                                            puntero++;
                                                            if (lista_nodos[puntero].token == 112) //+
                                                            {
                                                                puntero++;
                                                                if (lista_nodos[puntero].token == 107) //)
                                                                {
                                                                    puntero++;
                                                                    if (lista_nodos[puntero].token == 108) //{
                                                                    {
                                                                        puntero++;
                                                                        Statement();

                                                                        if (lista_nodos[puntero].token == 214) //break
                                                                        {
                                                                            puntero++;
                                                                            if (lista_nodos[puntero].token == 109) //}
                                                                            {
                                                                                puntero++;
                                                                            }
                                                                            else
                                                                            {
                                                                                LlenarFallaSintaxis();
                                                                            }
                                                                        }
                                                                        else if (lista_nodos[puntero].token == 215) //continue
                                                                        {
                                                                            puntero++;
                                                                            if (lista_nodos[puntero].token == 109) //}
                                                                            {
                                                                                puntero++;
                                                                            }
                                                                            else
                                                                            {
                                                                                LlenarFallaSintaxis();
                                                                            }
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        LlenarFallaSintaxis();
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    LlenarFallaSintaxis();
                                                                }
                                                            }
                                                            else
                                                            {
                                                                LlenarFallaSintaxis();
                                                            }
                                                        }
                                                        else if (lista_nodos[puntero].token == 113) //-
                                                        {
                                                            puntero++;
                                                            if (lista_nodos[puntero].token == 113) //-
                                                            {
                                                                puntero++;
                                                                if (lista_nodos[puntero].token == 107) //)
                                                                {
                                                                    puntero++;
                                                                    if (lista_nodos[puntero].token == 108) //{
                                                                    {
                                                                        puntero++;
                                                                        Statement();

                                                                        if (lista_nodos[puntero].token == 214) //break
                                                                        {
                                                                            puntero++;
                                                                            if (lista_nodos[puntero].token == 109) //}
                                                                            {
                                                                                puntero++;
                                                                            }
                                                                            else
                                                                            {
                                                                                LlenarFallaSintaxis();
                                                                            }
                                                                        }
                                                                        else if (lista_nodos[puntero].token == 215) //continue
                                                                        {
                                                                            puntero++;
                                                                            if (lista_nodos[puntero].token == 109) //}
                                                                            {
                                                                                puntero++;
                                                                            }
                                                                            else
                                                                            {
                                                                                LlenarFallaSintaxis();
                                                                            }
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        LlenarFallaSintaxis();
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    LlenarFallaSintaxis();
                                                                }
                                                            }
                                                            else
                                                            {
                                                                LlenarFallaSintaxis();
                                                            }
                                                        }
                                                    }
                                                    else
                                                    {
                                                        LlenarFallaSintaxis();
                                                    }
                                                }
                                                else
                                                {
                                                    LlenarFallaSintaxis();
                                                }
                                            }
                                            else
                                            {
                                                LlenarFallaSintaxis();
                                            }
                                        }
                                        else
                                        {
                                            LlenarFallaSintaxis();
                                        }
                                    }
                                    else
                                    {
                                        LlenarFallaSintaxis();
                                    }
                                }
                                else
                                {
                                    LlenarFallaSintaxis();
                                }
                            }
                            else
                            {
                                LlenarFallaSintaxis();
                            }
                        }
                        else
                        {
                            LlenarFallaSintaxis();
                        }
                    }
                    else
                    {
                        LlenarFallaSintaxis();
                    }
                }
                else
                {
                    LlenarFallaSintaxis();
                }
            }
            catch
            {
                BuscarFallaSintaxis();
            }
            return puntero;
        }


        public int EsScan()
        {
            try
            {
                if (lista_nodos[puntero].token == 204) //print
                {
                    puntero++;
                    if (lista_nodos[puntero].token == 106) //(
                    {
                        puntero++;
                        if (lista_nodos[puntero].token == 124) //""
                        {
                            puntero++;
                            if (lista_nodos[puntero].token == 107)
                            {
                                puntero++;
                            }
                            else if (lista_nodos[puntero].token == 105)
                            {
                                puntero++;
                                if (lista_nodos[puntero].token == 100)
                                {
                                    puntero++;
                                    if (lista_nodos[puntero].token == 107) //)
                                    {
                                        puntero++;
                                    }
                                    else
                                    {
                                        LlenarFallaSintaxis();
                                    }
                                }

                            }
                        }
                        else if (lista_nodos[puntero].token == 100)
                        {
                            puntero++;
                            if (lista_nodos[puntero].token == 107) //)
                            {
                                puntero++;
                            }
                            else
                            {
                                LlenarFallaSintaxis();
                            }
                        }
                        else
                        {
                            LlenarFallaSintaxis();
                        }
                    }
                    else
                    {
                        LlenarFallaSintaxis();
                    }
                }

            }
            catch
            {

            }
            return puntero;
        }

        public int EsElse()
        {
            try
            {
                //else
                if (lista_nodos[puntero].token == 210)
                {
                    puntero++;
                    //{
                    if (lista_nodos[puntero].token == 108)
                    {
                        puntero++;
                        puntero = Statement_list();
                        //}
                        if (lista_nodos[puntero].token == 109)
                        {
                            puntero++;
                        }
                    }
                }
            }
            catch
            {

            }
            return puntero;
        }

        public int valor_cadena()
        {
            try
            {
                // cadena
                if (lista_nodos[puntero].token == 124)
                {
                    puntero++;
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            return puntero;
        }

        public int valor_num()
        {
            try
            {
                if (lista_nodos[puntero].token == 101 || lista_nodos[puntero].token == 102)
                {
                    puntero++;
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            return puntero;
        }

        public int valor_log()
        {
            try
            {  //               true                             false
                if (lista_nodos[puntero].token == 212 || lista_nodos[puntero].token == 213)
                {
                    puntero++;
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            return puntero;
        }

        public int op_log1()
        {
            try
            {
                // !=
                if (lista_nodos[puntero].token == 118)
                {
                    puntero++;
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            return puntero;
        }

        public int op_log2()
        {
            try
            {
                //        &&                                ||
                if (lista_nodos[puntero].token == 125 || lista_nodos[puntero].token == 126)
                {
                    puntero++;
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            return puntero;
        }

        public int op_num()
        {
            try
            {
                //        +                                   -                                           *                      /   
                if (lista_nodos[puntero].token == 112 || lista_nodos[puntero].token == 113 || lista_nodos[puntero].token == 117 || lista_nodos[puntero].token == 115)
                {
                    puntero++;
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            return puntero;
        }

        public int op_rel()
        {
            try
            {
                //        <                                   >                                           <=                      >=                                !=
                if (lista_nodos[puntero].token == 119 || lista_nodos[puntero].token == 120 || lista_nodos[puntero].token == 121 || lista_nodos[puntero].token == 122 || lista_nodos[puntero].token == 118 || lista_nodos[puntero].token == 129)
                {
                    puntero++;
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            return puntero;
        }

        public int exp_rel()
        {
            try
            {
                //         valor numerico
                if (lista_nodos[puntero].token == 101 || lista_nodos[puntero].token == 102)
                {
                    puntero++;
                    puntero = valor_num();

                    //op_rel
                    if (lista_nodos[puntero].token == 119 || lista_nodos[puntero].token == 120 || lista_nodos[puntero].token == 121 || lista_nodos[puntero].token == 122 || lista_nodos[puntero].token == 118 || lista_nodos[puntero].token == 129)
                    {
                        puntero++;
                        puntero = op_rel();

                        //valor numerico
                        if (lista_nodos[puntero].token == 101 || lista_nodos[puntero].token == 102)
                        {
                            puntero++;
                            puntero = valor_num();
                        }
                        else
                        {
                            if (lista_nodos[puntero].token == 100)
                            {
                                puntero++;
                            }
                        }
                    }
                    else
                    {
                        LlenarFallaSintaxis();
                    }
                } //id
                else if (lista_nodos[puntero].token == 100)
                {
                    puntero++;

                    //op_rel
                    if (lista_nodos[puntero].token == 119 || lista_nodos[puntero].token == 120 || lista_nodos[puntero].token == 121 || lista_nodos[puntero].token == 122 || lista_nodos[puntero].token == 118 || lista_nodos[puntero].token == 129)
                    {
                        puntero++;
                        puntero = op_rel();

                        //id
                        if (lista_nodos[puntero].token == 100)
                        {
                            puntero++;

                        }
                        else
                        {
                            //valor numerico
                            if (lista_nodos[puntero].token == 101 || lista_nodos[puntero].token == 102)
                            {
                                puntero++;
                                puntero = valor_num();
                            }
                        }
                    }
                    else
                    {
                        LlenarFallaSintaxis();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            return puntero;
        }

        public int EsPrint()
        {
            try
            {
                if (lista_nodos[puntero].token == 203) //print
                {
                    puntero++;
                    if (lista_nodos[puntero].token == 106) //(
                    {
                        puntero++;
                        if (lista_nodos[puntero].token == 124) //""
                        {
                            puntero++;
                            if (lista_nodos[puntero].token == 107)
                            {
                                puntero++;
                            }
                            else if (lista_nodos[puntero].token == 105)
                            {
                                puntero++;
                                if (lista_nodos[puntero].token == 100)
                                {
                                    puntero++;
                                    if (lista_nodos[puntero].token == 107) //)
                                    {
                                        puntero++;
                                    }
                                    else
                                    {
                                        LlenarFallaSintaxis();
                                    }
                                }

                            }
                        }
                        else if (lista_nodos[puntero].token == 100)
                        {
                            puntero++;
                            if (lista_nodos[puntero].token == 107) //)
                            {
                                puntero++;
                            }
                            else
                            {
                                LlenarFallaSintaxis();
                            }
                        }
                        else
                        {
                            LlenarFallaSintaxis();
                        }
                    }
                    else
                    {
                        LlenarFallaSintaxis();
                    }
                }
            }
            catch
            {
                BuscarFallaSintaxis();
            }
            return puntero;
        }

        public int exp_log()
        {
            try
            {
                if (lista_nodos[puntero].token == 100 || lista_nodos[puntero].token == 101 || lista_nodos[puntero].token == 102)
                {
                    puntero++;
                    puntero = exp_rel();
                    if (lista_nodos[puntero].token == 118 || lista_nodos[puntero].token == 125 || lista_nodos[puntero].token == 126)
                    {
                        puntero++;
                        puntero = op_log1();
                        puntero = op_log2();
                        if (lista_nodos[puntero].token == 100 || lista_nodos[puntero].token == 101 || lista_nodos[puntero].token == 102)
                        {
                            puntero++;
                            puntero = exp_rel();
                        }
                        else
                        {
                            LlenarFallaSintaxis();
                        }

                    }
                    else
                    {
                        LlenarFallaSintaxis();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            return puntero;
        }

        public int exp_num()
        {
            try
            {
                /*  if (lista_nodos[puntero].token == 101 || lista_nodos[puntero].token == 102) // valor numerico
                  {
                      puntero++;
                      puntero = valor_num();
                  }
                  else*/
                if (lista_nodos[puntero].token == 101 || lista_nodos[puntero].token == 102) //valor numerico
                {
                    puntero++;
                    puntero = valor_num();

                    if (lista_nodos[puntero].token == 112 || lista_nodos[puntero].token == 113 || lista_nodos[puntero].token == 117 || lista_nodos[puntero].token == 115) //op_num
                    {
                        puntero++;
                        puntero = op_num();

                        if (lista_nodos[puntero].token == 101 || lista_nodos[puntero].token == 102) //valor numerico
                        {
                            puntero++;
                            puntero = valor_num();
                        }
                        else
                        {
                            LlenarFallaSintaxis();
                        }
                    }
                    else
                    {
                        LlenarFallaSintaxis();
                    }
                }
                else if (lista_nodos[puntero].token == 112 || lista_nodos[puntero].token == 113 || lista_nodos[puntero].token == 117 || lista_nodos[puntero].token == 115) // op_num
                {
                    puntero++;
                    puntero = op_num();

                    if (lista_nodos[puntero].token == 101 || lista_nodos[puntero].token == 102) //valor numerico
                    {
                        puntero++;
                        puntero = valor_num();
                    }
                    else
                    {
                        LlenarFallaSintaxis();
                    }
                }
                else if (lista_nodos[puntero].token == 112 || lista_nodos[puntero].token == 113 || lista_nodos[puntero].token == 117 || lista_nodos[puntero].token == 115) // op_num
                {
                    puntero++;
                    puntero = op_num();

                    if (lista_nodos[puntero].token == 101 || lista_nodos[puntero].token == 102) //valor numerico
                    {
                        puntero++;
                        puntero = valor_num();

                        if (lista_nodos[puntero].token == 112 || lista_nodos[puntero].token == 113 || lista_nodos[puntero].token == 117 || lista_nodos[puntero].token == 115) // op_num
                        {
                            puntero++;
                            puntero = op_num();

                            if (lista_nodos[puntero].token == 101 || lista_nodos[puntero].token == 102) //valor numerico
                            {
                                puntero++;
                                puntero = valor_num();
                            }
                            else
                            {
                                LlenarFallaSintaxis();
                            }
                        }
                        else
                        {
                            LlenarFallaSintaxis();
                        }
                    }
                    else
                    {
                        LlenarFallaSintaxis();

                    }
                }
            }
            catch
            {
                //MessageBox.Show("Error");
            }
            return puntero++;
        }

        public void BuscarFallaSintaxis()
        {

            MessageBox.Show("Terminé la lista en " + lista_nodos[puntero-1].lexema + ", no se completó con exito");
        }

        public void LlenarFallaSintaxis()
        {
            Errores.Rows.Add(lista_nodos[puntero].token, "Error en " + '"'+lista_nodos[puntero].lexema + '"', lista_nodos[puntero - 1].renglon);

        }




    }



    
}