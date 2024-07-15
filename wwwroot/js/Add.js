$(document).ready(function(){
    $("body").on("click",".add_new_frm_field_btn", function (){ 
      console.log("clicked");
      var index = $(".form_field_outer").find(".form_field_outer_row").length + 1;
      $(".form_field_outer").append(`
          <div class="row form_field_outer_row">
              <div class="form-group col-md-6">
                <input type="text" class="form-control w_90" name="mobileb_no[]" id="mobileb_no_${index}" placeholder="Enter Product Name" required/>
              </div>
              <div class="form-group col-md-4">
                <input type="text" class="form-control w_90" name="mobileb_no[]" id="mobileb_no_1" placeholder="Enter Product Quantity" required/>

              </div>
              <div class="form-group col-md-2 add_del_btn_outer">
                <button class="btn_round add_node_btn_frm_field" title="Copy row">
                  <i class="fas fa-copy"></i>
                </button>

                <button class="btn_round remove_node_btn_frm_field" disabled>
                  <i class="fas fa-trash-alt"></i>
                </button>
              </div>
            </div>
        `);

      $(".form_field_outer").find(".remove_node_btn_frm_field:not(:first)").prop("disabled", false);
      $(".form_field_outer").find(".remove_node_btn_frm_field").first().prop("disabled", true);
    });
 });


    ///======Clone method
$(document).ready(function(){
    $("body").on("click", ".add_node_btn_frm_field", function (e) {
      var index = $(e.target).closest(".form_field_outer").find(".form_field_outer_row").length + 1;
      var cloned_el = $(e.target).closest(".form_field_outer_row").clone(true);

      $(e.target).closest(".form_field_outer").last().append(cloned_el).find(".remove_node_btn_frm_field:not(:first)").prop("disabled", false);

      $(e.target).closest(".form_field_outer").find(".remove_node_btn_frm_field").first().prop("disabled", true);
    
      //change id
      $(e.target).closest(".form_field_outer").find(".form_field_outer_row").last().find("input[type='text']").attr("id", "mobileb_no_"+index);

      $(e.target).closest(".form_field_outer").find(".form_field_outer_row").last().find("select").attr("id", "no_type_"+index);

      console.log(cloned_el);
      //count++;
    });
 });


$(document).ready(function(){
    //===== delete the form fieed row
    $("body").on("click", ".remove_node_btn_frm_field", function () {
      $(this).closest(".form_field_outer_row").remove();
      console.log("success");
    });
  });


