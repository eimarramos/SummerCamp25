import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { WelcomeComponent } from './welcome/welcome.component';
import { CursosComponent } from './cursos/cursos.component';
import { PeliculasComponent } from './peliculas/peliculas.component';
import { CursoDetalleComponent } from './curso-detalle/curso-detalle.component';
import { DemoFormComponent } from './demo-form/demo-form.component';
import { DemoRegistroComponent } from './demo-registro/demo-registro.component';
import { DemoFormBuilderComponent } from './demo-form-builder/demo-form-builder.component';
import { DemoValidacionesComponent } from './demo-validaciones/demo-validaciones.component';

const routes: Routes = [
  { path: '', component: WelcomeComponent },
  { path: 'cursos', component: CursosComponent },
  { path: 'peliculas', component: PeliculasComponent },
  { path: 'curso/:id', component: CursoDetalleComponent },
  { path: 'demo-form', component: DemoFormComponent },
  { path: 'demo-registro', component: DemoRegistroComponent },
  { path: 'demo-form-builder', component: DemoFormBuilderComponent },
  { path: 'demo-validaciones', component: DemoValidacionesComponent },
  { path: '**', redirectTo: '' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
