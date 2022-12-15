import { Component, EventEmitter, Input, OnInit, Output } from "@angular/core";
import { Author } from "../models/Author";
import { AuthorService } from "../services/authorservice.service";


@Component({
  selector: 'app-edit-author',
  templateUrl: './edit-author.component.html',
  styleUrls: ['./edit-author.component.css']
})

export class EditAuthorComponent implements OnInit {
  @Input() author?: Author;
  @Output() authorUpdated = new EventEmitter<Author[]>(); 

  constructor(private authorService: AuthorService) { }

  ngOnInit(): void {

  }

  updateAuthor(author: Author) {
    this.authorService
      .updateAuthor(author)
      .subscribe((author: Author[]) => this.authorUpdated.emit(author))
  }

  deleteAuthor(author: Author) {
    this.authorService
      .deleteAuthor(author)
      .subscribe((author: Author[]) => this.authorUpdated.emit(author))
  }

  createAuthor(author: Author) {
    this.authorService
      .createAuthor(author)
      .subscribe((author: Author[]) => this.authorUpdated.emit(author))
  }
}
