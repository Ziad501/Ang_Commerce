import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';

import { AppComponent } from './app.component';
import { NotfoundComponent } from './notfound/notfound.component';
import { ProductListComponent } from './components/product-list/product-list.component';
import { CategoryListComponent } from './components/category-list/category-list.component';
import { HeaderComponent } from './home/components/header/header.component';
import { HomeModule } from './home/home.module';

@NgModule({
  declarations: [
    AppComponent,
    NotfoundComponent,
    ProductListComponent,
    CategoryListComponent,
    HeaderComponent // Register HeaderComponent properly
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    FontAwesomeModule,
    HomeModule // Ensure HomeModule is imported correctly
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
