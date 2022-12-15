import { Component } from "@angular/core";
import { Author } from "../models/Author";
import { AuthorService } from "../services/authorservice.service";

@Component({
  selector: 'app-author',
  templateUrl: './author.component.html',
  styleUrls: ['./author.component.css']
})

export class AuthorComponent {
  title = 'Author'
  authors: Author[] = [];
  authorToEdit?: Author;

  constructor(private authorService: AuthorService) {

  }

  ngOnInit(): void {
        this.authorService
      .getAuthors()
      .subscribe((result: Author[]) => (this.authors = result));
  }

  updateAuthorList(authors: Author[]) {
    this.authors = authors;
  }

  initNewAuthor() {
    this.authorToEdit = new Author();

  }


  editAuthor(author: Author) {
    this.authorToEdit = author;
  }
}
