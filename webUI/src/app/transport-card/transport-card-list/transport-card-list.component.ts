import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-transport-card-list',
  templateUrl: './transport-card-list.component.html',
  styleUrls: ['./transport-card-list.component.css']
})
export class TransportCardListComponent implements OnInit {

  constructor(private toastr: ToastrService) { }

  ngOnInit(): void {
  }

}
