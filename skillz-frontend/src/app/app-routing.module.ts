import { Component } from '@angular/core';
// app-routing.module.ts
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { SignupComponent } from './signup/signup.component'; // Import the new SignupComponent
import { SignupStepsComponent } from './signup-steps/signup-steps.component';
import { HomeComponent } from './home/home.component';

const routes: Routes = [
  { path: 'login', component: LoginComponent },
  { path: 'signup', component: SignupComponent }, // Add the route for the signup component
  { path: 'signup-steps', component: SignupStepsComponent},
  { path: 'home', component:HomeComponent}
  // Add other routes as needed
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
