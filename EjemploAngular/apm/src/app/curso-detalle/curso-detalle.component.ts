import { Component, inject, Input, input, OnInit } from '@angular/core';
import { CursosService } from '../cursos/cursos.service';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'pm-curso-detalle',
  templateUrl: './curso-detalle.component.html',
  styleUrl: './curso-detalle.component.css',
})
export class CursoDetalleComponent implements OnInit {
  cursosService = inject(CursosService);
  route = inject(ActivatedRoute);
  cursoId: number = 1;

  curso: any;

  ngOnInit() {
    this.cursoId = this.route.snapshot.params['id'];

    this.cursosService.getCursoById(this.cursoId).subscribe({
      next: (curso) => {
        this.curso = curso;
      },
      error: (err) => {
        // Manejar el error
      },
    });
  }
}
