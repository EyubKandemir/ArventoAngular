import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { environment } from "../../environments/environment";
import { Author } from "../models/Author";

@Injectable(
  {
    providedIn: 'root'
  })
export class AuthorService {
  private Geturl = "GetAuthors";
  private Updateurl = "UpdateAuthor";
  private Createurl = "CreateAuthor";
  private Deleteurl = "DeleteAuthor";

  constructor(private http: HttpClient ) { }

  //Get List
  public getAuthors(): Observable<Author[]> {
    var url2 = `${environment.apiUrl}/${this.Geturl}`;
    return this.http.get<any>(url2);
  }

  //Update 
  public updateAuthor(author: Author): Observable<Author[]> {
    var url2 = `${environment.apiUrl}/${this.Updateurl}`;
    return this.http.put<any>(url2, author);
  }

  //Create
  public createAuthor(author: Author): Observable<Author[]> {
    var url2 = `${environment.apiUrl}/${this.Createurl}`;
    return this.http.post<any>(url2, author);
  }

  //Delete

  public deleteAuthor(author: Author): Observable<Author[]> {
    var url2 = `${environment.apiUrl}/${this.Deleteurl}/${author.objectid}`;
    return this.http.delete<any>(url2);
  }

}
