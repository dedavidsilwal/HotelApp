import { Component, OnInit } from '@angular/core';
import { HotelTypeDto } from '../hotel/models/hotel-type-dto';
import { PagedResultDto, ListService } from '@abp/ng.core';
import { ConfirmationService, Confirmation } from '@abp/ng.theme.shared';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-hoteltype',
  templateUrl: './hoteltype.component.html',
})
export class HoteltypeComponent implements OnInit {

  hotelType = { items: [], totalCount: 0 } as PagedResultDto<HotelTypeDto>;

  selectedHotelType = new HotelTypeDto();

  form: FormGroup; // add this line


  isModalOpen = false; // add this line

  constructor(
    public readonly list: ListService,
    private fb: FormBuilder,
    private confirmation: ConfirmationService
  ) { }


  ngOnInit(): void {
  }

  create() {
    this.selectedHotelType = new HotelTypeDto();
    this.buildForm();
    this.isModalOpen = true;
  }
  edit(id: string) {
    // this.hotelService.getById(id).subscribe((hotel) => {
    //   this.selectedHotelType = hotel;
    //   this.buildForm();
    //   this.isModalOpen = true;
    // });
  }

  buildForm() {

    this.form = this.fb.group({
      name: [this.selectedHotelType.name || '', Validators.required],
      description: [this.selectedHotelType.description || '', Validators.required]
    });
  }

  save() {
    if (this.form.invalid) {
      return;
    }

    // const request = this.selectedHotelType.id
    //   ? this.hotelService.updateByIdAndInput(this.form.value, this.selectedHotelType.id)
    //   : this.hotelService.createByInput(this.form.value);

    // request.subscribe(() => {
    //   this.isModalOpen = false;
    //   this.form.reset();
    //   this.list.get();
    // });
  }

  delete(id: string) {
    this.confirmation.warn('::AreYouSureToDelete', '::AreYouSure').subscribe((status) => {
      if (status === Confirmation.Status.confirm) {
        // this.hotelService.deleteById(id).subscribe(() => this.list.get());
      }
    });
  }

}
