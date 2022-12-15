import { Component } from "@angular/core";
import { Books } from "../models/Books";
import { BookService } from "../services/bookservice.service";

@Component({
  selector: 'app-book',
  templateUrl: './book.component.html',
  styleUrls: ['./book.component.css']
})

export class BookComponent {
  title = 'Book'
  books: Books[] = [];
  bookToEdit?: Books;

  constructor(private bookService: BookService) {

  }

  ngOnInit(): void {
    this.bookService
      .getBooks()
      .subscribe((result: Books[]) => (this.books = result));
  }

  updateBookList(books: Books[]) {
    this.books = books;
  }

  initNewBook() {
    this.bookToEdit = new Books();

  }


  editBook(book: Books) {
    this.bookToEdit = book;
  }
}
