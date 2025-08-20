import { Component, inject, OnInit } from '@angular/core';
import { CursosService, ICurso } from '../cursos/cursos.service';
import { Router, ActivatedRoute } from '@angular/router';
import { Observable } from 'rxjs';

@Component({
  selector: 'pm-curso-detalle',
  templateUrl: './curso-detalle.component.html',
  styleUrl: './curso-detalle.component.css',
})
export class CursoDetalleComponent implements OnInit {
  cursosService = inject(CursosService);
  route = inject(ActivatedRoute);
  router = inject(Router);

  curso?: Observable<ICurso | undefined>;

  ngOnInit() {
    const cursoIdParam = this.route.snapshot.params['id'];

    const cursoId = Number(cursoIdParam);
    this.curso = this.cursosService.getCursoById(cursoId);
  }
}
