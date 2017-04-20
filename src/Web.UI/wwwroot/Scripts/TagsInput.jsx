var TagsInput = React.createClass({
    componentDidMount: function () {
        var _this = this;
        jQuery.getJSON("/api/tags/search?text=r").done(function (data) {
            console.log(data);
        });
    },

    render: function () {
        return (
            <div className="form-group">
                <label htmlFor="{this.props.property.name}" className="col-md-2 control-label">{this.props.property.label}</label>
                <div className="col-md-10">
                    <input name="{this.props.property.name}" className="form-control" />
                </div>
            </div>
        );
    }
});