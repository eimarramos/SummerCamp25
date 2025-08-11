import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { WelcomeComponent } from './welcome/welcome.component';
import { CounterDemoComponent } from './counter-demo/counter-demo.component';
import { CardDemoComponent } from './card-demo/card-demo.component';

@NgModule({
  declarations: [
    AppComponent,
    WelcomeComponent,
    CounterDemoComponent,
    CardDemoComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
