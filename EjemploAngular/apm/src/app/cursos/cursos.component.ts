import { Component, OnInit } from '@angular/core';
import { CursosService, ICurso } from './cursos.service';

@Component({
  selector: 'pm-cursos',
  templateUrl: './cursos.component.html',
  styleUrls: ['./cursos.component.css'],
})
export class CursosComponent implements OnInit {
  cursos: ICurso[] = [];
  errorMessage = '';
  loading = false;
  cursoSeleccionado = '';

  constructor(private cursosService: CursosService) {}

  ngOnInit(): void {
    this.loading = true;
    this.cursosService.getCursos().subscribe({
      next: (cursos) => {
        this.cursos = cursos;
        this.loading = false;
      },
      error: (err) => {
        this.errorMessage = err;
        this.loading = false;
      },
    });
  }

  onCursoClick(titulo: string): void {
    this.cursoSeleccionado = titulo;
    console.log('Curso seleccionado:', titulo);
  }
}
