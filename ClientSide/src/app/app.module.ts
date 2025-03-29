import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NotfoundComponent } from './notfound/notfound.component';
import { HomeModule } from './home/home.module';
import { ProductListComponent } from './components/product-list/product-list.component';
import { CategoryListComponent } from './components/category-list/category-list.component';
import { HeaderComponent } from './home/components/header/header.component';

@NgModule({
  declarations: [
    AppComponent,         // ✅ Declare AppComponent
    NotfoundComponent,    
    ProductListComponent, // ✅ Declare ProductListComponent
    CategoryListComponent,// ✅ Declare CategoryListComponent
    HeaderComponent       // ✅ Declare HeaderComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    FontAwesomeModule,
    HomeModule,  
    RouterModule  // ✅ Ensure RouterModule is imported for <router-outlet>
  ],
  providers: [],
  bootstrap: [AppComponent] // ✅ Bootstrapping AppComponent
})
export class AppModule { }