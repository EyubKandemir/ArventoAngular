import { Component, EventEmitter, Input, OnInit, Output } from "@angular/core";
import { Books } from "../models/Books";
import { BookService } from "../services/bookservice.service";


@Component({
  selector: 'app-edit-book',
  templateUrl: './edit-book.component.html',
  styleUrls: ['./edit-book.component.css']
})

export class EditBookComponent implements OnInit {
  @Input() book?: Books;
  @Output() bookUpdated = new EventEmitter<Books[]>(); 

  constructor(private bookService: BookService) { }


  ngOnInit(): void {
  }

  updateBook(book: Books) {
    this.bookService
      .updateBook(book)
      .subscribe((book: Books[]) => this.bookUpdated.emit(book))
  }

  deleteBook(book: Books) {
    this.bookService
      .deleteBook(book)
      .subscribe((book: Books[]) => this.bookUpdated.emit(book))
  }

  createBook(book: Books) {
    this.bookService
      .createBook(book)
      .subscribe((book: Books[]) => this.bookUpdated.emit(book))
  }
}
