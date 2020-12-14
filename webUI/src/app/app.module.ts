import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { ToastrModule } from 'ngx-toastr';

import { NavComponent } from './nav/nav.component';
import { HomeComponent } from './home/home.component';
import { TransportCardListComponent } from './transport-card/transport-card-list/transport-card-list.component';
import { TransportCardDetailsComponent } from './transport-card/transport-card-details/transport-card-details.component';
import { TransportCardDiscountedComponent } from './transport-card/transport-card-discounted/transport-card-discounted.component';
import { JourneyComponent } from './journey/journey.component';


@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    HomeComponent,
    TransportCardListComponent,
    TransportCardDetailsComponent,
    TransportCardDiscountedComponent,
    JourneyComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    FormsModule,
    BsDropdownModule.forRoot(),
    ToastrModule.forRoot({
      positionClass: 'toast-bottom-right'
    })
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
