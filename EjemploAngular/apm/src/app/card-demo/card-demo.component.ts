import { Component } from '@angular/core';

@Component({
  selector: 'pm-card-demo',
  templateUrl: './card-demo.component.html',
  styleUrl: './card-demo.component.css',
})
export class CardDemoComponent {
  titulo: string = 'Título de la tarjeta';
  contenido: string = 'Contenido de la tarjeta';
  imagenUrl: string = 'https://picsum.photos/200/300';
  fecha: string = new Date().toLocaleDateString();
}
