import react from "react";
import Card from "./card";
import FormFiles from "./addActivity";
import axios from 'axios';
import "./pagination.css";


class SearchBar extends react.Component {
    constructor(props) {
        super(props)
        this.state =
        {
            inputSearch: "",
            cardList: [],
            pages: [],
            currentPage: 1,
            itemsPerPage: 3,
            pageLimit: 5,
            maxPageLimit: 5,
            minPageLimit: 0,
            renderPageNumbers: [],
            currentItems: [],
            indexOfLastItem: this.currentPage * this.itemsPerPage,
            indexOfFirstItem: this.indexOfLastItem - this.itemsPerPage,
            data: []

        }
        this.handleChange = this.handleChange.bind(this);
        this.handleBtnBuscar = this.handleBtnBuscar.bind(this);
        this.handleClick = this.handleClick.bind(this);
        this.handlePrev = this.handlePrev.bind(this);
        this.handleNext = this.handleNext.bind(this);

    }

    handleChange(e) {
        this.setState({
            inputSearch: e.target.value
        })
    }

    renderItemPage = () => {
        this.setState((state) => ({ indexOfLastItem: state.currentPage * state.itemsPerPage }));
        this.setState((state) => ({ indexOfFirstItem: state.indexOfLastItem - state.itemsPerPage, }));
        this.setState((state) => ({
            renderPageNumbers: state.pages.map((number) => {
                if (number < state.maxPageLimit + 1 && number > state.minPageLimit) {
                    return (
                        <li
                            Key={number}
                            id={number}
                            onClick={this.handleClick}
                            className={state.currentPage == number ? "active" : null}
                        > {number}
                        </li>
                    );
                }
                else { return null; }
            })
        }));
        this.setState((state) => ({ currentItems: state.cardList.slice(state.indexOfFirstItem, state.indexOfLastItem) }));
    }
    handleBtnBuscar(e) {         
        axios(
            {
                method: 'get',
                url: 'http://10.0.0.11:4000/getActivity',
                params: { actName: this.state.inputSearch }
            }
        )
            .then(data => {
                this.setState({ pages:[]});
                this.setState((state) => ({
                    cardList: data.data,
                    indexOfLastItem: state.currentPage * state.itemsPerPage,
                    indexOfFirstItem: state.indexOfLastItem - state.itemsPerPage,
                }));
                for (let i = 1; i <= Math.ceil(data.data.length / this.state.itemsPerPage); i++) {
                    this.state.pages.push(i);
                }
                return data.data
            })
            .then(data => { this.renderItemPage(); })
    }
    handleClick(e) {
        this.setState({
            currentPage: Number(e.target.id)
        });
        this.renderItemPage();

    }
    handleNext(e){
        if (this.state.currentPage < this.state.pages[this.state.pages.length - 1])
        {
            this.setState((state)=>({currentPage:state.currentPage + 1}));
            this.renderItemPage();
        }

    }
    handlePrev(e){
        if (this.state.currentPage > this.state.pages[0])
        {
            this.setState((state)=>({currentPage:state.currentPage - 1}));
            this.renderItemPage();
        }
    }

    render() {
        const _carList = [];
        var key = 0;
        this.state.currentItems.map(item => {
            _carList.push(<div><Card Key={key++} actName={item.actName} description={item.description} files={item.files} date={item.date} id={item._id} folder={item.folder}/> <br /></div>)
        })
        
        return (
            <div className="row">
                <div className="col-sm-4">
                    <FormModal />
                </div>
                <div className="col-sm-4">
                    <input type="text" onChange={this.handleChange} value={this.state.inputSearch} className="form-control " placeholder="Escriba su búsqueda aquí..." />
                </div>
                <div className="col-sm-4">
                    <button type="button" value="Buscar" onClick={this.handleBtnBuscar} className="btn btn-warning text-white " >
                        <i className="bi bi-search" ></i>
                    </button>
                </div>
                <hr />
                {_carList}
                <div >

                    <ul className="justify-content-center pageNumbers">
                        <li className="">
                            <button onClick={this.handlePrev}>&laquo; Anterior</button>
                        </li>


                        {this.state.renderPageNumbers}

                        <li className="">
                            <button onClick={this.handleNext}>Siguiente &raquo;</button>
                        </li>
                    </ul>

                </div>
            </div>)
    }

}


function FormModal() {
    return (
        <div>
            <button type="button" className="btn bg-light  " data-bs-toggle="modal" data-bs-target="#staticBackdrop">
                <i className="bi bi-plus-circle" style={{ "fontSize": "2rem", color: "cornflowerblue" }}></i>
            </button>

            <div className="modal fade" id="staticBackdrop" data-bs-backdrop="static" data-bs-keyboard="false" tabIndex="-1" aria-labelledby="staticBackdropLabel" aria-hidden="true">
                <div className="modal-dialog">
                    <div className="modal-content">
                        <div className="modal-header">
                            <h5 className="modal-title" id="staticBackdropLabel">Registro de actividad</h5>
                            <button type="button" className="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                        </div>
                        <div className="modal-body">
                            <FormFiles />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    );
}


export default SearchBar;