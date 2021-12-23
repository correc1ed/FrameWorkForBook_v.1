using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace FrameWorkForBook
{
    public partial class Form1 : Form
    {
        public Books books = new Books();
        public static string FileName = @"TheBooks.json";
        public Form1()
        {
            InitializeComponent();
            books = Read(books);
            GetTable(books);
           

            textForAdditionalSearch.Visible = checkForAdditionalSearch.Checked;
            comboForAdditionalSearch.Visible = checkForAdditionalSearch.Checked;
        }





        void TabControlFrontEndFixed()
        {
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.Width = this.Width;
            tabControl.Height = this.Height;
            Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void timer_Tick(object sender, EventArgs e)
        {
          //  TabControlFrontEndFixed();
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book(textBookName.Text, textAuthor.Text, Convert.ToInt32(textPageCount.Text), comboValuation.Text);

                books.PersonList.Add(book);
                Write(books);
                MessageBox.Show("Книга внесена в список.");
                GetTable(books);
            }
            catch (Exception exception) { MessageBox.Show(exception.Message); }
        }

        public static void Write(Books books)
        {

            string ObjectSerialized = JsonSerializer.Serialize(books);
            File.WriteAllText(FileName, ObjectSerialized);

        }

        public static Books Read(Books books)
        {
            string ObjectJSONfile = File.ReadAllText(FileName);
            books = JsonSerializer.Deserialize<Books>(ObjectJSONfile);
            return books;
        }

        void GetTable(Books books)
        {
            listView.Items.Clear();
            foreach (Book book in books.PersonList)
            {
                var listviewitem = new ListViewItem(new string[] { book.BookName, book.Author, book.PageCount.ToString(), book.Valuation });
                listView.Items.Add(listviewitem);
            }
            label_forCount.Text = $"Количество прочитанных книг: {books.PersonList.Count}";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboDelete.Text)
                {
                    case "Название книги":
                        foreach (Book book in books.PersonList)
                        {
                            if (book.BookName == textDelete.Text && textDelete.Text != string.Empty)
                            {
                                books.PersonList.Remove(book);
                                Write(books);
                                break;
                            }

                        }
                        break;

                    case "Автор":
                        foreach (Book book in books.PersonList)
                        {
                            if (book.Author == textDelete.Text && textDelete.Text != string.Empty)
                            {
                                books.PersonList.Remove(book);
                                Write(books);
                                break;
                            }

                        }
                        break;
                    case "Количество страниц":
                        foreach (Book book in books.PersonList)
                        {
                            if (book.PageCount == Convert.ToInt32(textDelete.Text) && textDelete.Text != string.Empty)
                            {
                                books.PersonList.Remove(book);
                                Write(books);
                                break;
                            }

                        }
                        break;
                    case "Оценка":
                        foreach (Book book in books.PersonList)
                        {
                            if (book.Valuation == textDelete.Text && textDelete.Text != string.Empty)
                            {
                                books.PersonList.Remove(book);
                                Write(books);
                                break;
                            }

                        }
                        break;
                    default:
                        MessageBox.Show("Укажите элементы нормально.");
                        break;
                }
            }
            catch (Exception exception) { MessageBox.Show($"Ошибка: {exception.Message}"); }


            GetTable(books);
            MessageBox.Show("Элемент удалён.");
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            try
            {
                updateIn();
                GetTable(books);
                MessageBox.Show("Элемент изменён.");
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
            }
        }

        void updateIn()
        {
            try
            {

                switch (comboupdateIN.Text)
                {
                    case "Название книги":
                        foreach (Book book in books.PersonList)
                        {
                            if (book.BookName == textupdateIN.Text && textupdateIN.Text != string.Empty)
                            {
                                updateOut(book);
                                break;
                            }

                        }
                        break;

                    case "Автор":
                        foreach (Book book in books.PersonList)
                        {
                            if (book.Author == textupdateIN.Text && textupdateIN.Text != string.Empty)
                            {
                                updateOut(book);
                                break;
                            }
                        }
                        break;
                    case "Количество страниц":
                        foreach (Book book in books.PersonList)
                        {
                            if (book.PageCount == Convert.ToInt32(textupdateIN.Text) && textupdateIN.Text != string.Empty)
                            {
                                updateOut(book);
                                break;
                            }

                        }
                        break;
                    case "Оценка":
                        foreach (Book book in books.PersonList)
                        {
                            if (book.Valuation == textupdateIN.Text && textupdateIN.Text != string.Empty)
                            {
                                updateOut(book);
                                break;
                            }
                        }
                        break;
                    default:
                        MessageBox.Show("Укажите элементы нормально.");
                        break;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
            }
        }

        void updateOut(Book book)
        {
            try
            {

                switch (comboupdateOUT.Text)
                {
                    case "Название книги":

                        if (textupdateOUT.Text != string.Empty)
                        {
                            book.BookName = textupdateOUT.Text;
                            Write(books);
                            break;
                        }
                        break;

                    case "Автор":

                        if (textupdateOUT.Text != string.Empty)
                        {
                            book.Author = textupdateOUT.Text;
                            Write(books);
                            break;
                        }

                        break;
                    case "Количество страниц":

                        if (textupdateOUT.Text != string.Empty)
                        {
                            book.PageCount = Convert.ToInt32(textupdateOUT.Text);
                            Write(books);
                            break;
                        }

                        break;
                    case "Оценка":

                        if (textupdateOUT.Text != string.Empty)
                        {
                            book.Valuation = textupdateOUT.Text;
                            Write(books);
                            break;
                        }

                        break;
                    default:
                        MessageBox.Show("Укажите элементы нормально.");
                        break;


                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
            }
        }

        private void buttonForSearch_Click(object sender, EventArgs e)
        {
            try
            {
                listView.Items.Clear();
                int BookCount = 0;

                if (checkForAdditionalSearch.Checked == false)
                {
                    foreach (Book book in books.PersonList)
                    {
                        switch (comboFORsearch.Text)
                        {
                            case "Название книги":
                                if (textFORsearch.Text == book.BookName && textFORsearch.Text != string.Empty)
                                {

                                    var listviewitem = new ListViewItem(new string[] { book.BookName, book.Author, book.PageCount.ToString(), book.Valuation });
                                    listView.Items.Add(listviewitem);
                                    BookCount++;

                                }
                                break;

                            case "Автор":
                                if (textFORsearch.Text == book.Author && textFORsearch.Text != string.Empty)
                                {


                                    var listviewitem = new ListViewItem(new string[] { book.BookName, book.Author, book.PageCount.ToString(), book.Valuation });
                                    listView.Items.Add(listviewitem);
                                    BookCount++;
                                }
                                break;

                            case "Количество страниц":
                                if (Convert.ToInt32(textFORsearch.Text) == book.PageCount && textFORsearch.Text != string.Empty)
                                {

                                    var listviewitem = new ListViewItem(new string[] { book.BookName, book.Author, book.PageCount.ToString(), book.Valuation });
                                    listView.Items.Add(listviewitem);
                                    BookCount++;
                                }
                                break;

                            case "Оценка":
                                if (textFORsearch.Text == book.Valuation && textFORsearch.Text != string.Empty)
                                {


                                    var listviewitem = new ListViewItem(new string[] { book.BookName, book.Author, book.PageCount.ToString(), book.Valuation });
                                    listView.Items.Add(listviewitem);
                                    BookCount++;
                                }
                                break;
                          

                            default:
                                GetTable(books);
                                break;
                        }

                    }
                    if (textFORsearch.Text != string.Empty)
                    {
                        label_forCount.Text = $"Количество найденных книг: {BookCount}";
                    }
                    else
                    {
                        GetTable(books);
                    }
                }
                else
                {
                    foreach (Book book in books.PersonList)
                    {
                        switch (comboFORsearch.Text)
                        {
                            case "Название книги":
                                if (textFORsearch.Text == book.BookName && textFORsearch.Text != string.Empty)
                                {
                                    if (AdditionalSearch(book) == true)
                                    {
                                         var listviewitem = new ListViewItem(new string[] { book.BookName, book.Author, book.PageCount.ToString(), book.Valuation });
                                         listView.Items.Add(listviewitem);
                                        BookCount++;
                                    }
                                   
                                }
                                break;

                            case "Автор":
                                if (textFORsearch.Text == book.Author && textFORsearch.Text != string.Empty)
                                {
                                    if (AdditionalSearch(book) == true)
                                    {
                                        var listviewitem = new ListViewItem(new string[] { book.BookName, book.Author, book.PageCount.ToString(), book.Valuation });
                                        listView.Items.Add(listviewitem);
                                        BookCount++;
                                    }
                                }
                                break;

                            case "Количество страниц":
                                if (Convert.ToInt32(textFORsearch.Text) == book.PageCount && textFORsearch.Text != string.Empty)
                                {
                                    if (AdditionalSearch(book) == true)
                                    {
                                        var listviewitem = new ListViewItem(new string[] { book.BookName, book.Author, book.PageCount.ToString(), book.Valuation });
                                        listView.Items.Add(listviewitem);
                                        BookCount++;
                                    }
                                }
                                break;

                            case "Оценка":
                                if (textFORsearch.Text == book.Valuation && textFORsearch.Text != string.Empty)
                                {
                                    if (AdditionalSearch(book) == true)
                                    {
                                        var listviewitem = new ListViewItem(new string[] { book.BookName, book.Author, book.PageCount.ToString(), book.Valuation });
                                        listView.Items.Add(listviewitem);
                                        BookCount++;
                                    }
                                }
                                break;
                          
                            default:
                                GetTable(books);
                                break;
                        }

                    }
                    label_forCount.Text = $"Количество найденных книг: {BookCount}";
                }


            }
            catch (Exception exception) { MessageBox.Show($"Ошибка: {exception.Message}"); }


        }

        bool AdditionalSearch(Book book)
        {
            bool Operator = false;

            if (checkForAdditionalSearch.Checked == true && textForAdditionalSearch.Text != string.Empty && comboForAdditionalSearch.Text != string.Empty)
            {
                switch (comboForAdditionalSearch.Text)
                {
                    case "Название книги":
                        if (textForAdditionalSearch.Text == book.BookName && textForAdditionalSearch.Text != string.Empty)
                        {
                            Operator = true;
                        }
                        break;

                    case "Автор":
                        if (textForAdditionalSearch.Text == book.Author && textForAdditionalSearch.Text != string.Empty)
                        {
                            Operator = true;
                        }

                        break;

                    case "Количество страниц":
                        if (Convert.ToInt32(textForAdditionalSearch.Text) == book.PageCount && textForAdditionalSearch.Text != string.Empty)
                        {
                            Operator = true;
                        }

                        break;

                    case "Оценка":
                        if (textForAdditionalSearch.Text == book.Valuation && textForAdditionalSearch.Text != string.Empty)
                        {
                            Operator = true;
                        }

                        break;
                    default:
                        break;

                }
            }
            else
            { Operator = false;  }
            
            return Operator;
        }

        private void checkForAdditionalSearch_CheckedChanged(object sender, EventArgs e)
        {
            textForAdditionalSearch.Visible = checkForAdditionalSearch.Checked;
            comboForAdditionalSearch.Visible = checkForAdditionalSearch.Checked;
        }

        private void buttonClear_search_Click(object sender, EventArgs e)
        {
            comboFORsearch.Text = string.Empty;
            textFORsearch.Text = string.Empty;

            comboForAdditionalSearch.Text = string.Empty;
            textForAdditionalSearch.Text = string.Empty;
        }

        private void buttonClear_add_Click(object sender, EventArgs e)
        {
            textBookName.Text = string.Empty;
            textAuthor.Text = string.Empty;
            textPageCount.Text = string.Empty;
            comboValuation.Text = string.Empty;
        }

        private void buttonClear_delete_Click(object sender, EventArgs e)
        {
            comboDelete.Text = string.Empty;
            textDelete.Text = string.Empty;
        }

        private void buttonClear_update_Click(object sender, EventArgs e)
        {
            comboupdateIN.Text = string.Empty;
            textupdateIN.Text = string.Empty;

            comboupdateOUT.Text = string.Empty;
            textupdateOUT.Text = string.Empty;
        }
    }

    [Serializable]
    public class Book
    {
        public string BookName { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }
        public string Valuation { get; set; }

        public Book(string bookname, string author, int pagecount, string valuation)
        {
            this.BookName = bookname;
            this.Author = author;
            this.PageCount = pagecount;
            this.Valuation = valuation;
        }

        private Book() { }
    }
    public class Books
    {
        public List<Book> PersonList { get; set; } = new List<Book>();
    }
}
