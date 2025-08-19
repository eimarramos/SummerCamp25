import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'pm-counter-demo',
  templateUrl: './counter-demo.component.html',
  styleUrl: './counter-demo.component.css',
})
export class CounterDemoComponent implements OnInit {
  @Input() valorInicial: number = 0;
  contador: number = 0;

  ngOnInit() {
    this.contador = this.valorInicial;
  }

  incrementar() {
    this.contador++;
  }

  decrementar() {
    this.contador--;
  }

  resetear() {
    this.contador = this.valorInicial;
  }
}
