import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';

export interface IPelicula {
  title: string;
  episode_id: number;
  opening_crawl: string;
  director: string;
  producer: string;
  release_date: string;
  // Puedes agregar más campos según la respuesta de la API
}

@Injectable({
  providedIn: 'root',
})
export class PeliculasService {
  private peliculasUrl = 'https://swapi.online/api/films';

  constructor(private http: HttpClient) {}

  getPeliculas(): Observable<IPelicula[]> {
    return this.http.get<any>(this.peliculasUrl).pipe(
      tap((data) => console.log('Peliculas:', JSON.stringify(data))),
      map((response) => {
        // Si la respuesta es un array, la devolvemos tal cual
        if (Array.isArray(response)) {
          return response as IPelicula[];
        }
        // Si la respuesta tiene 'results', devolvemos esa propiedad
        if (response && Array.isArray(response.results)) {
          return response.results as IPelicula[];
        }
        // Si no, devolvemos un array vacío
        return [];
      }),
      catchError(this.handleError)
    );
  }

  private handleError(err: HttpErrorResponse) {
    let errorMessage = '';
    if (err.error instanceof ErrorEvent) {
      errorMessage = `An error occurred: ${err.error.message}`;
    } else {
      errorMessage = `Server returned code: ${err.status}, error message is: ${err.message}`;
    }
    console.error(errorMessage);
    return throwError(() => errorMessage);
  }
}
