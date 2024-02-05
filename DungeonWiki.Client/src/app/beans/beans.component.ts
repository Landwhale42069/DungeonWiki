import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-beans',
  standalone: true,
  imports: [],
  templateUrl: './beans.component.html',
  styleUrl: './beans.component.scss'
})
export class BeansComponent implements OnInit {
  constructor(private route: ActivatedRoute) {}

  param: string = "asdasd";
  ngOnInit(): void {
    this.route.params.subscribe(params => {
      this.param = params['param'];
    });
  }
}
