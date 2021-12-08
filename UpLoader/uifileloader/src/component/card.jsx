import react from "react";
import axios from 'axios';
import { ToastContainer, toast } from 'react-toastify';

class Card extends react.Component {
    constructor(props) {
        super(props)
        this.state = {
            id: this.props.id,
            folder: [],
            finalFolder: ""
        }
        this.handleClick = this.handleClick.bind(this);
    }

    handleClick() {
        if (window.confirm('Esta seguro que desea eliminar la actividad'))
            axios(
                {
                    method: 'get',
                    url: 'http://10.0.0.11:4000/deleteActivity',
                    params: { _id: this.state.id }
                }
            )
                .then(data => {
                    toast.warn("Data was deleted!", { position: toast.POSITION.TOP_CENTER });
                })

    }
    static getDerivedStateFromProps(props, state) {
        state.folder = props.folder.split("/");
        state.finalFolder = state.folder[state.folder.length - 1];
    }
    render() {
        const files = [];
        if (this.props.files) {
            this.props.files.map(fl => {
                files.push(<a href={"http://10.0.0.6:4000/download/" + this.state.finalFolder + "/" + fl} download={fl} value={fl} className="card-link">{fl}</a>);
            })
        }

        return (
            <div className="card w-70 p-3  shadow-lg by-white rounded-start" Key={this.state.id}>
                <h5 className="card-header bg-transparent">{this.props.actName}</h5>
                <p className="fs-6 text-secondary">{this.props.date} </p>

                <div className="card-body" >
                    <p className="card-text">{this.props.description}</p>
                </div>

                <div className="card-footer" style={{ "backGroundColor": "#eee" }}>
                    <div  >
                        {files}
                    </div>
                    <div  >
                        <button type="button" className="btn btn-danger" onClick={this.handleClick}><i className="bi bi-trash"></i></button>
                    </div>
                </div>
                <ToastContainer />

            </div>
        )
    }
}

export default Card