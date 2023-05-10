using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopCleanCode
{
    public class BubbleSort
    {
        public void SelectionSort(string variable, bool ascending, List<ProductProxy> products)
        {
            if (variable.Equals("price")) { 
                int length = products.Count;
                for (int i = 0; i < length - 1; i++)
                {
                    //for each number
                    int min = i;
                    //We find the smallest number
                    for (int j = i + 1; j < length;
                    j++)
                    {
                        if (products[j].Price < products[min].Price)
                        {
                            min = j;
                        }
                    }
                    //And we swap their spots
                    int temp = products[i].Price;
                    products[i].Price = products[min].Price;
                    products[min].Price = temp;
                } // Before moving on to the next
                if (!ascending) { products.Reverse();}
            }
            if (variable.Equals("name"))
            {
                int length = products.Count;
                for (int i = 0; i < length - 1; i++)
                {
                    //for each number
                    int min = i;
                    //We find the smallest number
                    for (int j = i + 1; j < length;
                    j++)
                    {
                        if (products[j].Name.CompareTo(products[min].Name) < 0)
                        {
                            min = j;
                        }
                    }
                    //And we swap their spots
                    string temp = products[i].Name;
                    products[i].Name = products[min].Name;
                    products[min].Name = temp;
                } // Before moving on to the next
                if (!ascending) { products.Reverse(); }
            }

        }
        public void bubbleSort(string variable, bool ascending, List<ProductProxy> products)
        {
            if (variable.Equals("name"))
            {
                int length = products.Count;
                for (int i = 0; i < length - 1; i++)
                {
                    bool sorted = true;
                    int length2 = length - i;
                    for (int j = 0; j < length2 - 1; j++)
                    {
                        if (ascending)
                        {
                            if (products[j].Name.CompareTo(products[j + 1].Name) < 0)
                            {
                                ProductProxy temp = products[j];
                                products[j] = products[j + 1];
                                products[j + 1] = temp;
                                sorted = false;
                            }
                        }
                        else
                        {
                            if (products[j].Name.CompareTo(products[j + 1].Name) > 0)
                            {
                                ProductProxy temp = products[j];
                                products[j] = products[j + 1];
                                products[j + 1] = temp;
                                sorted = false;
                            }
                        }
                    }
                    if (sorted == true)
                    {
                        break;
                    }
                }
            }
            else if (variable.Equals("price"))
            {
                int length = products.Count;
                for (int i = 0; i < length - 1; i++)
                {
                    bool sorted = true;
                    int length2 = length - i;
                    for (int j = 0; j < length2 - 1; j++)
                    {
                        if (ascending)
                        {
                            if (products[j].Price > products[j + 1].Price)
                            {
                                ProductProxy temp = products[j];
                                products[j] = products[j + 1];
                                products[j + 1] = temp;
                                sorted = false;
                            }
                        }
                        else
                        {
                            if (products[j].Price < products[j + 1].Price)
                            {
                                ProductProxy temp = products[j];
                                products[j] = products[j + 1];
                                products[j + 1] = temp;
                                sorted = false;
                            }
                        }
                    }
                    if (sorted == true)
                    {
                        break;
                    }
                }
            }
        }
    }
}
