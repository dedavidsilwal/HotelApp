import { ListService, PagedResultDto } from '@abp/ng.core';
import { Component, OnInit } from '@angular/core';
import { HotelService } from './services/hotel.service';
import { HotelDto } from './models';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { ConfirmationService, Confirmation } from '@abp/ng.theme.shared';

@Component({
  selector: 'app-hotel',
  templateUrl: './hotel.component.html',
  styleUrls: ['./hotel.component.scss'],
  providers: [ListService],

})
export class HotelComponent implements OnInit {

  hotel = { items: [], totalCount: 0 } as PagedResultDto<HotelDto>;

  selectedHotel = new HotelDto();

  form: FormGroup; // add this line


  isModalOpen = false; // add this line


  constructor(
    public readonly list: ListService,
    private hotelService: HotelService,
    private fb: FormBuilder,
    private confirmation: ConfirmationService
  ) { }

  ngOnInit() {
    const hotelStreamCreator = (query) => this.hotelService.getListByInput(query);

    this.list.hookToQuery(hotelStreamCreator).subscribe((response) => {
      this.hotel = response;
    });
  }


  createHotel() {
    this.selectedHotel = new HotelDto();
    this.buildForm();
    this.isModalOpen = true;
  }

  editHotel(id: string) {
    this.hotelService.getById(id).subscribe((hotel) => {
      this.selectedHotel = hotel;
      this.buildForm();
      this.isModalOpen = true;
    });
  }

  buildForm() {

    this.form = this.fb.group({
      name: [this.selectedHotel.name || '', Validators.required],
      shortDescription: [this.selectedHotel.shortDescription || '', Validators.required],
      fullDescription: [this.selectedHotel.fullDescription || ''],
      showOnHomePage: [this.selectedHotel.name || false, Validators.required],
      isEnabled: [this.selectedHotel.isEnabled || true, Validators.required],
      // allowCustomerReviews: [this.selectedHotel.allowCustomerReviews || true, Validators.required],
      defaultPicture: [this.selectedHotel.defaultPicture || '', Validators.required],
    });
  }

  save() {
    if (this.form.invalid) {
      return;
    }

    const request = this.selectedHotel.id
      ? this.hotelService.updateByIdAndInput(this.form.value, this.selectedHotel.id)
      : this.hotelService.createByInput(this.form.value);

    request.subscribe(() => {
      this.isModalOpen = false;
      this.form.reset();
      this.list.get();
    });
  }

  delete(id: string) {
    this.confirmation.warn('::AreYouSureToDelete', '::AreYouSure').subscribe((status) => {
      if (status === Confirmation.Status.confirm) {
        this.hotelService.deleteById(id).subscribe(() => this.list.get());
      }
    });
  }

}
