import { Component, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'pm-card-demo',
  templateUrl: './card-demo.component.html',
  styleUrl: './card-demo.component.css',
})
export class CardDemoComponent {
  @Input() id: number = 0;
  @Input() titulo: string = 'Título de la tarjeta';
  @Input() contenido: string = 'Contenido de la tarjeta';
  @Input() imagenUrl: string = 'https://picsum.photos/200/300';
  @Input() fecha: string = new Date().toLocaleDateString();
  @Input() autor: string = 'Autor';

  @Output() cardClick = new EventEmitter<string>();

  onCardClick(): void {
    this.cardClick.emit(this.titulo);
  }
}
