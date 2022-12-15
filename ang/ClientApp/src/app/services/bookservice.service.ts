import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { environment } from "../../environments/environment";
import { Books } from "../models/Books";

@Injectable(
  {
    providedIn: 'root'
  })
export class BookService {
  private Geturl = "GetBooks";
  private Updateurl = "UpdateBook";
  private Createurl = "CreateBook";
  private Deleteurl = "DeleteBook";

  constructor(private http: HttpClient) { }

  //get list
  public getBooks(): Observable<Books[]> {
    var url = `${environment.apiBookUrl}/${this.Geturl}`;
    return this.http.get<any>(url);
  }

  //Update
  public updateBook(book: Books): Observable<Books[]> {
    var url = `${environment.apiBookUrl}/${this.Updateurl}`;
    return this.http.put<any>(url,book);

  }

  //Create
  public createBook(book: Books): Observable<Books[]> {
    var url = `${environment.apiBookUrl}/${this.Createurl}`;
    return this.http.post<any>(url, book);

  }

  //Delete
  public deleteBook(book: Books): Observable<Books[]> {
    var url = `${environment.apiBookUrl}/${this.Deleteurl}/${book.objectid}`;
    return this.http.delete<any>(url);

  }
}
