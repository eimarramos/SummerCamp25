import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, tap } from 'rxjs/operators';

export interface ICurso {
  id: number;
  titulo: string;
  descripcion: string;
  urlImagen: string;
  fecha: string;
  autor: string;
}

@Injectable({
  providedIn: 'root',
})
export class CursosService {
  private cursosUrl = 'api/cursos.json';

  constructor(private http: HttpClient) {}

  getCursos(): Observable<ICurso[]> {
    return this.http.get<ICurso[]>(this.cursosUrl).pipe(
      tap((data) => console.log('Cursos:', JSON.stringify(data))),
      catchError(this.handleError)
    );
  }

  getCursoById(id: number): Observable<ICurso> {
    return this.http.get<ICurso>(`${this.cursosUrl}/${id}`).pipe(
      tap((data) => console.log('Curso:', JSON.stringify(data))),
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
