import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { EquipmentservicesService } from '../equipmentservices.service';
import * as $ from "jquery";
@Component({
  selector: 'app-editpage',
  templateUrl: './editpage.component.html',
  styleUrls: ['./editpage.component.css']
})
export class EditpageComponent implements OnInit {
  sub: Subscription | undefined;
  xeq: any;
  xhomeeq: any;
  update_eq_id: number | undefined;
  url: string = '';
  constructor(private serve: EquipmentservicesService, private route: ActivatedRoute, private _router: Router, private http: HttpClient, @Inject('BASE_URL') baseUrl: string) { this.url = baseUrl }
  ngOnInit(): void {
    this.sub = this.route.paramMap.subscribe(params => {
      let id = params.get("id");
      this.xhomeeq = this.serve.HomepageList.filter(a => a.equipmentId.toString() === id);
      this.xhomeeq = this.xhomeeq[0]
    })
    //console.log(this.serve.HomepageList);
  }
  SaveData(xlocation: any, yread: any) {
        if (yread.value.length === 0) {
          alert('Reading Is Missing')
        } else {
          var read_loaction_object = {
            nlocation: xlocation.value,
            record_reading: parseInt(yread.value),
            equipmentId: this.xhomeeq.equipmentId
          }
          console.log(read_loaction_object);
          this._router.navigate(['Home'])
        }       
//// post data to api
        $.ajax({
          type: "POST",
          url: this.url +'api/HomepageApi',
          data: JSON.stringify(read_loaction_object),// now data come in this function
          contentType: "application/json; charset=utf-8",
          crossDomain: true,
          dataType: "json",
          success: function (data, status, jqXHR) {
              alert("success");// write success in " " 
          },
          error: function (jqXHR, status) {
              // error handler
              console.log(jqXHR);
         //     alert('faile' + status.code);
          }
       });
  //// post data to api
  }
  Recording_Reading(xread: any) {
  }
}
