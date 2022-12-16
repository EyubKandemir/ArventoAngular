import { Component,OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import {  Router, RouterModule } from '@angular/router';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(private loginAuth: AuthService, private router: Router) { }

  ngOnInit(): void {
  }


  loginForm = new FormGroup({
    username: new FormControl (),
    pwd: new FormControl ()
  });

  isUserValid: boolean = false;

//  SubmitClicked() {
//    this.loginAuth.loginUser([this.loginForm.value.username, this.loginForm.value.pwd]).subscribe(res => {
//      console.log(res.toString);
//      if (res.toString() == 'Failure') {
//        this.isUserValid = false;
//        alert('Login Unsuccesful');
//      } else {
//        this.isUserValid = true;
//        alert('Login Successfull!!!!!!');
//      }
//});
//  }

  SubmitClicked() {
   
    var res = this.loginAuth.loginUser([this.loginForm.value.username, this.loginForm.value.pwd]).subscribe();
    this.router.navigateByUrl('/home');

  }

  get Username(): FormControl {
    return this.loginForm.get('username') as FormControl;
  }

  get PWD(): FormControl {

    return this.loginForm.get('pwd') as FormControl;
  }
}
