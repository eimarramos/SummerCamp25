import { Component } from '@angular/core';

@Component({
  selector: 'pm-counter-demo',
  templateUrl: './counter-demo.component.html',
  styleUrl: './counter-demo.component.css',
})
export class CounterDemoComponent {
  contador: number = 0;

  incrementar() {
    this.contador++;
  }

  decrementar() {
    this.contador--;
  }

  resetear() {
    this.contador = 0;
  }
}
