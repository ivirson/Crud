import { ProductService } from './../product.service';
import { Product } from './../product.model';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-product-read',
  templateUrl: './product-read.component.html',
  styleUrls: ['./product-read.component.css']
})
export class ProductReadComponent implements OnInit {

  products: Product[]
  displayedColumns = ['id', 'name', 'price', 'action']

  constructor(private productService: ProductService) { }

  ngOnInit() {
    this.productService.read().subscribe(products => {
      this.products = products
      //console.table(products)
    })
  }



  responderFelicitacao(msg: string) {
    while (msg === "Parabéns @Ivirson Daltro ! Muita saúde e felicidades irmão! Que Deus continue lhe abençoando e protegendo! Saúde e felicidades à você e família! Abraços!")
    {
      return "Obrigado pelas felicitações!"
    }
  }
  



}
