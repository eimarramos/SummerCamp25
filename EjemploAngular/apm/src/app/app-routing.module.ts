import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { WelcomeComponent } from './welcome/welcome.component';
import { CursosComponent } from './cursos/cursos.component';
import { PeliculasComponent } from './peliculas/peliculas.component';
import { CursoDetalleComponent } from './curso-detalle/curso-detalle.component';

const routes: Routes = [
  { path: '', component: WelcomeComponent },
  { path: 'cursos', component: CursosComponent },
  { path: 'peliculas', component: PeliculasComponent },
  { path: 'curso/:id', component: CursoDetalleComponent },
  { path: '**', redirectTo: '' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
