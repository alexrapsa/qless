import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { JourneyComponent } from './journey/journey.component';
import { TransportCardListComponent } from './transport-card/transport-card-list/transport-card-list.component';

const routes: Routes = [
  {path: '', component: HomeComponent},
  {path: 'transportcard', component: TransportCardListComponent},
  {path: 'journey', component: JourneyComponent},
  {path: '**', component: HomeComponent, pathMatch: 'full'},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
