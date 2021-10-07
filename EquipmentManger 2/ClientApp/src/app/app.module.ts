import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { EditpageComponent } from './editpage/editpage.component';
import { HomePageComponent } from './home-page/home-page.component';
import { NavBarComponent } from './nav-bar/nav-bar.component';
import { ActivitiesComponent } from './activities/activities.component';
import { SetActivityComponent } from './set-activity/set-activity.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    EditpageComponent,
    HomePageComponent,
    NavBarComponent,
    ActivitiesComponent,
    SetActivityComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomePageComponent, pathMatch: 'full' },
     // { path: 'counter', component: CounterComponent },
     // { path: 'fetch-data', component: FetchDataComponent },
     {path:'Activities',component:ActivitiesComponent,pathMatch:'full'},
     {path:'Edit/:id', component: EditpageComponent , pathMatch:'full'},
     { path: 'Home', component: HomePageComponent, pathMatch: 'full' },
     {path:'SetActivity/:id', component:SetActivityComponent , pathMatch:'full'}
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
