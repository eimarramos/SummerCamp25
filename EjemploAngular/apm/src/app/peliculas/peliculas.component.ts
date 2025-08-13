import { Component, OnInit } from '@angular/core';
import { PeliculasService, IPelicula } from './peliculas.service';

@Component({
  selector: 'pm-peliculas',
  templateUrl: './peliculas.component.html',
  styleUrls: ['./peliculas.component.css'],
})
export class PeliculasComponent implements OnInit {
  peliculas: IPelicula[] = [];
  errorMessage = '';
  loading = false;

  constructor(private peliculasService: PeliculasService) {}

  ngOnInit(): void {
    this.loading = true;
    this.peliculasService.getPeliculas().subscribe({
      next: (peliculas) => {
        this.peliculas = peliculas;
        this.loading = false;
      },
      error: (err) => {
        this.errorMessage = err;
        this.loading = false;
      },
    });
  }
}
