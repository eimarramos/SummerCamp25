import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { WelcomeComponent } from './welcome/welcome.component';
import { CounterDemoComponent } from './counter-demo/counter-demo.component';
import { CardDemoComponent } from './card-demo/card-demo.component';
import { PeliculasComponent } from './peliculas/peliculas.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CursosComponent } from './cursos/cursos.component';
import { NavbarComponent } from './navbar/navbar.component';
import { CursoDetalleComponent } from './curso-detalle/curso-detalle.component';
import { DemoFormComponent } from './demo-form/demo-form.component';
import { DemoRegistroComponent } from './demo-registro/demo-registro.component';
import { DemoFormBuilderComponent } from './demo-form-builder/demo-form-builder.component';
import { DemoValidacionesComponent } from './demo-validaciones/demo-validaciones.component';

@NgModule({
  declarations: [
    AppComponent,
    WelcomeComponent,
    CounterDemoComponent,
    CardDemoComponent,
    PeliculasComponent,
    CursosComponent,
    NavbarComponent,
    CursoDetalleComponent,
    DemoFormComponent,
    DemoRegistroComponent,
    DemoFormBuilderComponent,
    DemoValidacionesComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
