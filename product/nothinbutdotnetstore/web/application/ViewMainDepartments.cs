﻿using nothinbutdotnetstore.domain;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.web.application
{
    public class ViewMainDepartments : ApplicationCommand
    {
        Repository repository;
        ResponseEngine response_engine;


        public ViewMainDepartments(Repository repository, ResponseEngine response_engine)
        {
            this.repository = repository;
            this.response_engine = response_engine;
        }

        public void process(Request request)
        {
            response_engine.display(repository.get_all_main_departments());
        }
    }
}