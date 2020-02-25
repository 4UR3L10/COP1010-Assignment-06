using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DStructures
{
    public partial class FormDataStructures : Form
    {
        public int[] IntArray ;
        public int index = 0;
        public FormDataStructures()
        {
            InitializeComponent();
        }
        /**
         * 1. Parse the value entered in the textbox to an int
         * 2. Declares an int variable
         * 3. Instantiates the array
         * 4. Enters in a loop, and populates the array with random numbers
         * 5. Adds the values of the array to the listBoxOriginal List
         * 6. Disables the buttons showValues and ORderList
         */
        private void buttonShowValues_Click(object sender, EventArgs e)
        {
            int counter = Int32.Parse(textBoxNumbers.Text);
            int number;
            IntArray = new int[counter];
            Random rand = new Random();
            for (int i = 0; i < counter; i++)
            {
                number = rand.Next(100);
                IntArray[i] = number;
                listBoxOriginalList.Items.Add(number);
            }

            buttonShowValues.Enabled = false;
            buttonOrderList.Enabled = true;
        }
        /**
         * 1. Validates the input in the button shown values
         */
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            buttonShowValues.Enabled = !string.IsNullOrEmpty(textBoxNumbers.Text);
        }
        /**
         * 1. Clears all the elements in the form
         */
        private void buttonClear_Click(object sender, EventArgs e)
        {
            FormDataStructures NewForm = new FormDataStructures();
            NewForm.Show();
            this.Dispose(false);
        }
        /**
         * 1. Closes form
         */
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /**
         * 1. Orders the array, using selection sort
         * 2. Adds the sorted items to the listBox SortedList
         * 3. Displays the message of the runnning time complexity
         */
        private void buttonOrderList_Click(object sender, EventArgs e)
        {
            SelectionSort(IntArray);
            foreach (int value in IntArray)
            {
                listBoxSortedList.Items.Add(value);
            }
            MessageBox.Show("The big O in all cases is O(n^2)");
        }
        /**
         * 1. PDeclares two int variables
         * 2. Enters in the first loop loop
         * 3. The value of startScan is assign to minIndex
         * 4. The value of the array atthe initital position is assigned to minValue
         * 5. Enters in the second loop
         * 6. Compares if the value of the index is less than the minValue. If true, 
         *    the value in Array at postion index will be pass to minvalue
         * 7. Calls th method swap passing two parameters of type array
         * 
         * 
         */
        private void SelectionSort(int [] iArray)
        {
            int minIndex;
            int minValue;
            for (int startScan = 0; startScan < iArray.Length-1; startScan++)
            {
                minIndex = startScan;
                minValue = iArray[startScan];

                for (int index = startScan+1; index < iArray.Length; index++)
                {
                    if (iArray[index] < minValue)
                    {
                        minValue = iArray[index];
                        minIndex = index;
                    }
                }
                Swap(ref iArray[minIndex], ref iArray[startScan]);

            }
        }
        /**
         * 1. The method swap receives two variables as parameters
         * 2. Switches the values of two elements using a temp varaibale
         */
        private void Swap (ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        /**
         * 1. The value of the pictureBox Next is obtained from the imageListCards at the index postions
         * 2. Compares if the index is equal to 7 . IF true, assignes the value 0 to index
         * 3. DIncreases the value of index
         */
        private void buttonNext_Click(object sender, EventArgs e)
        {
            
                pictureBoxNext.Image = imageListCards.Images[index];
            

            if (index == 7)
            {
                index =0;
            }
            index++;
        }
        /**
         * 1. The value of the index is decreaased
         * 2. Compares if the index is less to 0 or greater than 7 . IF true, assignes the value 0 to index
         * 3. Displays the value of the pictureBox PRevious.
         */
        private void buttonPrevious_Click(object sender, EventArgs e)
        {

            index--;

            if (index < 0 || index > 7)
            {
                index = 0;
            }
            else
            {
                
                pictureBoxPrevious.Image = imageListCards.Images[index];
            }
        }
    }
}
